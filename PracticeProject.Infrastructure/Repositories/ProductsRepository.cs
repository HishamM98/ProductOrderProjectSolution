using Microsoft.EntityFrameworkCore;
using PracticeProject.Core.Domain.Entities;
using PracticeProject.Core.Domain.RepositoryContracts;
using PracticeProject.Core.Enums;
using PracticeProject.Infrastructure.DbContext;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject.Infrastructure.Repositories
{
    public class ProductsRepository(ApplicationDbContext db) : IProductsRepository
    {
        private readonly ApplicationDbContext _db = db;

        public async Task<Product> AddProduct(Product product)
        {
            _db.Products.Add(product);
            await _db.SaveChangesAsync();

            return product;
        }

        public async Task<bool> DeleteProductByProductID(Guid productID)
        {
            var product = await _db.Products.FindAsync(productID);
            if (product == null)
            {
                return false;
            }
            _db.Products.Remove(product);
            int rowsDeleted = await _db.SaveChangesAsync();

            return rowsDeleted > 0;
        }

        public async Task<Product?> EditProduct(Product product)
        {
            var matchingProduct = await _db.Products.FindAsync(product.Id);
            if (matchingProduct == null)
            {
                return null;
            }
            matchingProduct.Name = product.Name;
            matchingProduct.Description = product.Description;
            matchingProduct.StockQuantity = product.StockQuantity;
            matchingProduct.Price = product.Price;

            await _db.SaveChangesAsync();

            return matchingProduct;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _db.Products.ToListAsync();
        }

        public async Task<Product?> GetProductByProductID(Guid productID)
        {
            return await _db.Products.FindAsync(productID);
        }

        public async Task<List<Product>> GetProductsByCategory(ProductCategory category)
        {
            return await _db.Products.Where(p => p.Category == category.ToString()).ToListAsync();
        }
    }
}
