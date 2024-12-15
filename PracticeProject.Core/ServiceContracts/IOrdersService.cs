using PracticeProject.Core.Domain.Entities;
using PracticeProject.Core.DTO.OrderDTOs;
using PracticeProject.Core.Enums;
using PracticeProject.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject.Core.ServiceContracts
{
    public interface IOrdersService
    {
        Task<List<OrderResponse>> GetOrders(OrdersQuery ordersQuery);
        Task<OrderResponse?> GetOrderById(Guid orderId);
        Task<OrderResponse?> EditOrder(OrderUpdateRequest orderUpdateRequest);
        Task<OrderResponse?> AddOrder(OrderAddRequest orderAddRequest);
        Task<bool> DeleteOrder(Guid orderId);
    }
}
