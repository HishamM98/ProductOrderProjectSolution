using PracticeProject.Core.Domain.Entities;
using PracticeProject.Core.Domain.IdentityEntities;
using PracticeProject.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject.Core.DTO.OrderDTOs
{
    public class OrderResponse
    {
        public Guid Id { get; set; }
        public List<OrderItem> OrderItems { get; set; } = [];
        public decimal TotalAmount =>
            OrderItems?.Sum(item => item.Quantity * item.UnitPrice) ?? 0;
        public string Status { get; set; } = OrderStatus.Pending.ToString();
        public DateTime CreatedAt { get; set; }
    }
}
