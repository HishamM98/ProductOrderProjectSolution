using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PracticeProject.Core.Domain.IdentityEntities;
using PracticeProject.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject.Core.Domain.Entities
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }
        public Guid? UserId { get; set; }
        public User? User { get; set; }
        public List<OrderItem> OrderItems { get; set; } = [];
        public decimal TotalAmount =>
            OrderItems?.Sum(item => item.Quantity * item.UnitPrice) ?? 0;
        public string Status { get; set; } = OrderStatus.Pending.ToString();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
