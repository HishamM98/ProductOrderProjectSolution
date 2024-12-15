using PracticeProject.Core.Domain.Entities;
using PracticeProject.Core.Enums;
using PracticeProject.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject.Core.Domain.RepositoryContracts
{
    public interface IProductsRepository
    {
        Task<Product?> GetProductByProductID(Guid productID);
        Task<List<Product>> GetAllProducts(ProductsQuery query);
        Task<Product> AddProduct(Product product);
        Task<Product?> EditProduct(Product product);
        Task<bool> DeleteProductByProductID(Guid productID);
        Task<List<Product>> GetProductsByCategory(ProductCategory category);
    }
}
