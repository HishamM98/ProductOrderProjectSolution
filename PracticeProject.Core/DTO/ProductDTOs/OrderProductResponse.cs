using PracticeProject.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject.Core.DTO.ProductDTOs
{
    public class OrderProductResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }

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

    public static partial class ProductExtensions
    {
        public static OrderProductResponse ToOrderProductResponse(this Product product)
        {
            return new OrderProductResponse
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
            };
        }
    }
}

