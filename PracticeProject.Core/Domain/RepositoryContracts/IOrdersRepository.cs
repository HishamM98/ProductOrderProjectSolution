using PracticeProject.Core.Domain.Entities;
using PracticeProject.Core.Enums;
using PracticeProject.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject.Core.Domain.RepositoryContracts
{
    public interface IOrdersRepository
    {
        Task<Order?> GetOrderByOrderID(Guid orderID, Guid userID);
        Task<List<Order>> GetAllOrders(OrdersQuery ordersQuery, Guid userID);
        Task<Order> AddOrder(Order order);
        Task<bool> RemoveOrder(Guid orderID, Guid userID);
        Task<Order?> EditOrder(Order order, Guid userID);
    }
}
