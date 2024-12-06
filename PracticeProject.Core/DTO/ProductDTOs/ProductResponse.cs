using PracticeProject.Core.Domain.Entities;
using PracticeProject.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject.Core.DTO.ProductDTOs
{
    public class ProductResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string Category { get; set; } = string.Empty;

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            if (obj.GetType() != typeof(ProductResponse)) return false;

            ProductResponse product = (ProductResponse)obj;
            return Name == product.Name && Price == product.Price && Description == product.Description;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nDescription: {Description}\nPrice: {Price}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public static class ProductExtensions
    {
        public static ProductResponse ToProductResponse(this Product product)
        {
            return new ProductResponse
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                StockQuantity = product.StockQuantity,
                Category = product.Category,
            };
        }
    }
}
