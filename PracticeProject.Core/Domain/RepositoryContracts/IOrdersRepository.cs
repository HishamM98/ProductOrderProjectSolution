using PracticeProject.Core.Domain.Entities;
using PracticeProject.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject.Core.Domain.RepositoryContracts
{
    public interface IOrdersRepository
    {
        Task<Order?> GetOrderByOrderID(Guid orderID);
        Task<List<Order>> GetAllOrders();
        Task<Order?> AddOrder(Order order);
        Task<bool> RemoveOrder(Guid orderID);
        Task<Order> EditOrder(Order order);
        Task<Order> GetOrderByStatus(OrderStatus status);
    }
}
