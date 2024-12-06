using PracticeProject.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject.Core.DTO.OrderItemDTOs
{
    public class OrderItemAddReq
    {
        [Required]
        public Guid ProductId { get; set; }
        [Required]
        public Guid OrderId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }

        public OrderItem ToOrderItem()
        {
            return new OrderItem
            {
                ProductId = ProductId,
                OrderId = OrderId,
                Quantity = Quantity,
                UnitPrice = UnitPrice
            };
        }
    }
}
