using System;
using System.Collections.Generic;
using System.Linq;
using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PracticeProject.Core.DTO.ProductDTOs;
using PracticeProject.Core.Helpers;
using PracticeProject.Core.ServiceContracts;

namespace PracticeProject.WebAPI.Controllers.v1
{
    /// <summary>
    /// Product Controller that handles product's endpoints
    /// </summary>
    /// <param name="productsService"></param>
    [ApiVersion("1.0")]
    //[Route("api/v{version:apiVersion}/[controller]")]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductsController(IProductsService productsService) : ControllerBase
    {
        private readonly IProductsService _productsService = productsService;

        // GET: api/Products
        /// <summary>
        /// Get all Products that match query filters and allows pagination and sorting
        /// </summary>
        /// <param name="query">query filters that filters using category and price and supports pagination and sorting</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<List<ProductResponse>>> GetProducts([FromQuery] ProductsQuery query)
        {
            return await _productsService.GetAllProducts(query);
        }

        // GET: api/Products/5
        /// <summary>
        /// Get product by its ID
        /// </summary>
        /// <param name="id">Product's ID</param>
        /// <returns></returns>
        [HttpGet("{id:guid:required}")]
        public async Task<ActionResult<ProductResponse>> GetProduct([FromRoute] Guid id)
        {
            var product = await _productsService.GetProductByProductID(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        /// <summary>
        /// Update product's details
        /// </summary>
        /// <param name="id">Product's ID</param>
        /// <param name="productUpdateRequest">Updated Product's Data</param>
        /// <returns></returns>
        [HttpPut("{id:guid:required}")]
        public async Task<ActionResult<ProductResponse>> PutProduct([FromRoute] Guid id, [FromBody] ProductUpdateRequest productUpdateRequest)
        {
            if (!ModelState.IsValid)
            {
                return ValidationProblem();
            }

            if (id != productUpdateRequest.Id)
            {
                return BadRequest("ID Mismatch");
            }

            ProductResponse? productResponse = await _productsService.EditProduct(productUpdateRequest);

            if (productResponse is null) { return NotFound("No such product available"); }

            return productResponse;
        }

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        /// <summary>
        /// Add new product
        /// </summary>
        /// <param name="productAddrequest"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<ProductResponse>> PostProduct([FromBody] ProductAddRequest productAddrequest)
        {
            if (!ModelState.IsValid)
            {
                var errorString = string.Join(" - ", ModelState.Values.SelectMany(temp => temp.Errors).Select(e => e.ErrorMessage));
                return BadRequest(errorString);
            }

            ProductResponse productResponse = await _productsService.AddProduct(productAddrequest);
            //
            return CreatedAtAction("GetProduct", new { id = productResponse.Id }, value: productResponse);
        }

        // DELETE: api/Products/5
        /// <summary>
        /// Remove product using its ID
        /// </summary>
        /// <param name="id">Prdouct's ID</param>
        /// <returns></returns>
        [HttpDelete("{id:guid:required}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] Guid id)
        {
            var deleteResponse = await _productsService.DeleteProductByID(id);

            if (!deleteResponse) return BadRequest("Couldn't delete product or no such product available!");

            return NoContent();
        }

    }
}
