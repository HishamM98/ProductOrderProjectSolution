using PracticeProject.Core.Domain.Entities;
using PracticeProject.Core.DTO.ProductDTOs;
using PracticeProject.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject.Core.ServiceContracts
{
    public interface IProductsService
    {
        Task<ProductResponse?> GetProductByProductID(Guid productID);
        Task<List<ProductResponse>> GetAllProducts();
        Task<ProductResponse> AddProduct(ProductAddRequest productAddRequest);
        Task<ProductResponse?> EditProduct(ProductUpdateRequest productEditRequest);
        Task<bool> DeleteProductByID(Guid productID);
        Task<List<ProductResponse>> GetProductsByCategory(ProductCategory category);
    }
}
