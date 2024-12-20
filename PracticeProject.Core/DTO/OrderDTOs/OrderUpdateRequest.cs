﻿using PracticeProject.Core.Domain.Entities;
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
    public class OrderUpdateRequest
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public List<OrderItemUpdateReq> OrderItems { get; set; } = [];
        [Required]
        public OrderStatus Status { get; set; }

        public Order ToOrder()
        {
            return new Order
            {
                Id = Id,
                OrderItems = OrderItems.Select(oi=>oi.ToOrderItem()).ToList(),
                Status = Status.ToString()
            };
        }
    }
}
