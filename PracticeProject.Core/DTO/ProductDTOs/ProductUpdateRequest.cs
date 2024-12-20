﻿using PracticeProject.Core.Domain.Entities;
using PracticeProject.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject.Core.DTO.ProductDTOs
{
    public class ProductUpdateRequest
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(500)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Range(0.01, 9999999.99, ErrorMessage = "Price must be greater than zero")]
        public decimal Price { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Stock quantity cannot be negative")]
        public int StockQuantity { get; set; }

        public ProductCategory Category { get; set; }

        public Product ToProduct()
        {
            return new Product { Id = Id, Name = Name, Description = Description, Price = Price, StockQuantity = StockQuantity, Category = Category.ToString() };
        }
    }
}
