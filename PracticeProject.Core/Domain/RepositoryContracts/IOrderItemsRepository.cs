using PracticeProject.Core.Domain.Entities;
using PracticeProject.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject.Core.Domain.RepositoryContracts
{
    public interface IOrderItemsRepository
    {
        Task<OrderItem?> GetOrderItemByID(Guid orderItemID);
        Task<List<OrderItem>> GetAllOrderItems();
        Task<OrderItem> AddOrderItem(OrderItem orderItem);
        Task<OrderItem> EditOrderItem(OrderItem orderItem);
        Task<bool> DeleteOrderItemByID(Guid orderItemID);
    }
}
