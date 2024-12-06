using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PracticeProject.Core.DTO.ProductDTOs;
using PracticeProject.Core.ServiceContracts;

namespace PracticeProject.WebAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController(IProductsService productsService) : ControllerBase
    {
        private readonly IProductsService _productsService = productsService;

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductResponse>>> GetProducts()
        {
            return await _productsService.GetAllProducts();
        }

        // GET: api/Products/5
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

            if(productResponse is null) { return NotFound("No such product available"); }

            return productResponse;
        }

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductResponse>> PostProduct([FromBody] ProductAddRequest productAddrequest)
        {
            if (!ModelState.IsValid)
            {
                var errorString = String.Join(" - ", ModelState.Values.SelectMany(temp => temp.Errors).Select(e => e.ErrorMessage));
                return BadRequest(errorString);
            }

            ProductResponse productResponse = await _productsService.AddProduct(productAddrequest);
            //
            return CreatedAtAction("GetProduct", new { id = productResponse.Id }, value: productResponse);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id:guid:required}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] Guid id)
        {
            var deleteResponse = await _productsService.DeleteProductByID(id);

            if (!deleteResponse) return BadRequest("Couldn't delete product or no such product available!");

            return NoContent();
        }

    }
}
