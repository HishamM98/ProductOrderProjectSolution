using PracticeProject.Core.Domain.Entities;
using PracticeProject.Core.Domain.RepositoryContracts;
using PracticeProject.Core.DTO.ProductDTOs;
using PracticeProject.Core.Enums;
using PracticeProject.Core.Helpers;
using PracticeProject.Core.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject.Core.Services
{
    public class ProductsService(IProductsRepository productsRepository) : IProductsService
    {
        private readonly IProductsRepository _productsRepository = productsRepository;

        public async Task<ProductResponse> AddProduct(ProductAddRequest? productAddRequest)
        {
            ArgumentNullException.ThrowIfNull(productAddRequest, nameof(productAddRequest));

            Product product = productAddRequest.ToProduct();

            await _productsRepository.AddProduct(product);

            return product.ToProductResponse();
        }

        public async Task<bool> DeleteProductByID(Guid? productID)
        {
            ArgumentNullException.ThrowIfNull(productID, nameof(productID));

            bool isDeleted = await _productsRepository.DeleteProductByProductID(productID.Value);

            return isDeleted;
        }

        public async Task<ProductResponse?> EditProduct(ProductUpdateRequest productEditRequest)
        {
            
            Product? updatedProduct= await _productsRepository.EditProduct(productEditRequest.ToProduct());

            if (updatedProduct is null) return null;

            return updatedProduct.ToProductResponse();
        }

        public async Task<List<ProductResponse>> GetAllProducts(ProductsQuery query)
        {
            var products = await _productsRepository.GetAllProducts(query);
            return products.Select(p=>p.ToProductResponse()).ToList();
        }

        public async Task<ProductResponse?> GetProductByProductID(Guid productID)
        {
            var product = await _productsRepository.GetProductByProductID(productID);
            return product?.ToProductResponse();
        }

        public async Task<List<ProductResponse>> GetProductsByCategory(ProductCategory category)
        {
            var products = await _productsRepository.GetProductsByCategory(category);
            return products.Select(p=>p.ToProductResponse()).ToList();
        }

    }
}
