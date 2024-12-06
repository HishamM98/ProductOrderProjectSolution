﻿using PracticeProject.Core.Domain.Entities;
using PracticeProject.Core.Domain.IdentityEntities;
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
        public Guid Id { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public List<OrderItem> OrderItems { get; set; } = [];
    }
}