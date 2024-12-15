using PracticeProject.Core.Domain.Entities;
using PracticeProject.Core.Domain.IdentityEntities;
using PracticeProject.Core.DTO.OrderItemDTOs;
using PracticeProject.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject.Core.DTO.OrderDTOs
{
    public class OrderAddRequest
    {
        [Required]
        public List<OrderItemAddReq> OrderItems { get; set; } = [];

        public Order ToOrder()
        {
            return new Order
            {
                OrderItems = OrderItems.Select(oi=> oi.ToOrderItem()).ToList(),
            };
        }
    }
}
