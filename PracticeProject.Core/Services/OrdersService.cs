using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using PracticeProject.Core.Domain.Entities;
using PracticeProject.Core.Domain.RepositoryContracts;
using PracticeProject.Core.DTO.OrderDTOs;
using PracticeProject.Core.Helpers;
using PracticeProject.Core.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject.Core.Services
{
    public class OrdersService(IOrdersRepository ordersRepository, IProductsRepository productsRepository, IHttpContextAccessor httpContextAccessor) : IOrdersService
    {
        private readonly IOrdersRepository _ordersRepository = ordersRepository;
        private readonly IProductsRepository _productsRepository = productsRepository;
        private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;

        public async Task<OrderResponse?> AddOrder(OrderAddRequest orderAddRequest)
        {
            var order = orderAddRequest.ToOrder();
            var userId = GetUserID();

            order.UserId = userId;

            var isValidOrder = await IsOrderItemsValid(order.OrderItems);

            if (!isValidOrder) return null;

            await _ordersRepository.AddOrder(order);

            return order.ToOrderResponse();
        }

        public async Task<bool> DeleteOrder(Guid orderId)
        {
            var userId = GetUserID();

            var isDeleted = await _ordersRepository.RemoveOrder(orderId, userId);

            return isDeleted;
        }

        public async Task<OrderResponse?> EditOrder(OrderUpdateRequest orderUpdateRequest)
        {
            var userId = GetUserID();

            var order = orderUpdateRequest.ToOrder();

            var isValidOrder = await IsOrderItemsValid(order.OrderItems);

            if (!isValidOrder) return null;

            await _ordersRepository.EditOrder(order, userId);

            return order.ToOrderResponse();
        }

        public async Task<OrderResponse?> GetOrderById(Guid orderId)
        {
            var userId = GetUserID();

            var order = await _ordersRepository.GetOrderByOrderID(orderId, userId);
            return order?.ToOrderResponse();
        }

        public async Task<List<OrderResponse>> GetOrders(OrdersQuery ordersQuery)
        {
            var userId = GetUserID();

            var orders = await _ordersRepository.GetAllOrders(ordersQuery, userId);
            return orders.Select(o => o.ToOrderResponse()).ToList();
        }

        private async Task<bool> IsOrderItemsValid(List<OrderItem> orderItems)
        {
            foreach (var orderItem in orderItems)
            {
                var product = await _productsRepository.GetProductByProductID(orderItem.ProductId);

                if (product == null) return false;

                if (orderItem.Quantity > product.StockQuantity) return false;

                orderItem.UnitPrice = product.Price;
            }

            return true;
        }

        private Guid GetUserID()
        {
            var userId = (_httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value) ?? throw new SecurityTokenException("Invalid Token");

            return Guid.Parse(userId);
        }
    }
}
