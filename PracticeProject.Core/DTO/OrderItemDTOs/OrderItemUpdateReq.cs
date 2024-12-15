using PracticeProject.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject.Core.DTO.OrderItemDTOs
{
    public class OrderItemUpdateReq
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public Guid ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }

        public OrderItem ToOrderItem()
        {
            return new OrderItem
            {
                Id = Id,
                ProductId = ProductId,
                Quantity = Quantity
            };
        }
    }
}
