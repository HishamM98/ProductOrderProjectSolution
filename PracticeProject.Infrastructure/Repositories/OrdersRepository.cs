using Microsoft.EntityFrameworkCore;
using PracticeProject.Core.Domain.Entities;
using PracticeProject.Core.Domain.RepositoryContracts;
using PracticeProject.Core.Enums;
using PracticeProject.Core.Helpers;
using PracticeProject.Infrastructure.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject.Infrastructure.Repositories
{
    public class OrdersRepository(ApplicationDbContext db) : IOrdersRepository
    {
        private readonly ApplicationDbContext _db = db;
        public async Task<Order> AddOrder(Order order)
        {
            await _db.Orders.AddAsync(order);
            await _db.SaveChangesAsync();
            return order;
        }

        public async Task<Order?> EditOrder(Order order, Guid userID)
        {
            var matchingOrder = await _db.Orders.FirstOrDefaultAsync(o=> o.Id == order.Id && o.UserId == userID);
            if (matchingOrder == null) return null;

            matchingOrder.Status = order.Status;
            matchingOrder.OrderItems = order.OrderItems;

            await _db.SaveChangesAsync();

            return matchingOrder;
        }

        public async Task<List<Order>> GetAllOrders(OrdersQuery ordersQuery, Guid userId)
        {
            var orders = _db.Orders.Where(o=>o.UserId == userId).AsQueryable();

            if (!string.IsNullOrWhiteSpace(ordersQuery.Status))
            {
                orders = orders.Where(o => o.Status == ordersQuery.Status);
            }
            if (ordersQuery.OrdersBefore != null)
            {
                orders = orders.Where(o => o.CreatedAt <= ordersQuery.OrdersBefore);
            }
            if (ordersQuery.TotalMinPrice != null)
            {
                orders = orders.Where(o => o.TotalAmount >= ordersQuery.TotalMinPrice);
            }
            if (ordersQuery.TotalMaxPrice != null)
            {
                orders = orders.Where(o => o.TotalAmount <= ordersQuery.TotalMaxPrice);
            }
            if (ordersQuery.SortBy != null)
            {
                if (ordersQuery.SortBy.Equals(nameof(Order.TotalAmount), StringComparison.OrdinalIgnoreCase))
                {
                    orders = ordersQuery.IsDescending ? orders.OrderByDescending(o => o.TotalAmount) : orders.OrderBy(o => o.TotalAmount);
                }

                if (ordersQuery.SortBy.Equals(nameof(Order.CreatedAt), StringComparison.OrdinalIgnoreCase))
                {
                    orders = ordersQuery.IsDescending ? orders.OrderByDescending(o => o.CreatedAt) : orders.OrderBy(o => o.CreatedAt);
                }

                if (ordersQuery.SortBy.Equals(nameof(Order.Status), StringComparison.OrdinalIgnoreCase))
                {
                    orders = ordersQuery.IsDescending ? orders.OrderByDescending(o => o.Status) : orders.OrderBy(o => o.Status);
                }
            }

            int skip = (ordersQuery.PageNumber - 1) * ordersQuery.PageSize;

            return await orders.Include(o=>o.OrderItems).ThenInclude(oi => oi.Product).Skip(skip).Take(ordersQuery.PageSize).ToListAsync();
        }

        public async Task<Order?> GetOrderByOrderID(Guid orderID, Guid userID)
        {
            return await _db.Orders.Include(o => o.OrderItems).ThenInclude(oi => oi.Product).FirstOrDefaultAsync(o => o.Id == orderID && o.UserId == userID);
        }

        public async Task<bool> RemoveOrder(Guid orderID, Guid userID)
        {
            var order = await _db.Orders.FirstOrDefaultAsync(o => o.Id == orderID && o.UserId == userID);

            if (order == null) return false;

            _db.Orders.Remove(order);

            int rowsDeleted = await _db.SaveChangesAsync();

            return rowsDeleted > 0;
        }
    }
}
