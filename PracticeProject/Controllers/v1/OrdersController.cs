using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticeProject.Core.DTO.OrderDTOs;
using PracticeProject.Core.Helpers;
using PracticeProject.Core.ServiceContracts;
using System.Security.Claims;

namespace PracticeProject.WebAPI.Controllers.v1
{
    /// <summary>
    /// Orders Controller that handles order's endpoints
    /// </summary>
    /// <param name="orderService"></param>
    [ApiVersion("1.0")]
    //[Route("api/v{version:apiVersion}/[controller]")]
    [Route("api/v1/[controller]")]
    [Authorize]
    [ApiController]
    public class OrdersController(IOrdersService orderService) : ControllerBase
    {
        private readonly IOrdersService _ordersService = orderService;

        /// <summary>
        /// Get Order by its ID
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        [HttpGet("{orderId:guid:required}")]
        public async Task<IActionResult> GetOrderById([FromRoute] Guid orderId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var order = await _ordersService.GetOrderById(orderId);

            if (order == null) return NotFound();

            return Ok(order);
        }

        /// <summary>
        /// Get all user's orders
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAllOrders([FromQuery] OrdersQuery ordersQuery)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            var orders = await _ordersService.GetOrders(ordersQuery);

            return Ok(orders);
        }

        /// <summary>
        /// Create new order including order items
        /// </summary>
        /// <param name="orderAddRequest"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<OrderResponse>> PostOrder([FromBody] OrderAddRequest orderAddRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _ordersService.AddOrder(orderAddRequest);

            if (result == null) return BadRequest("Insufficient stock!");

            return result;
        }

        /// <summary>
        /// update order data
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="orderUpdateRequest"></param>
        /// <returns></returns>
        [HttpPut("{orderId:guid:required}")]
        public async Task<IActionResult> PutOrder([FromRoute] Guid orderId, [FromBody] OrderUpdateRequest orderUpdateRequest)
        {
            if (orderId != orderUpdateRequest.Id) return BadRequest();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var res = await _ordersService.EditOrder(orderUpdateRequest);

            if(res == null) return BadRequest(res);
            
            return Ok(res);
        }

        /// <summary>
        /// Cancel order using its ID
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        [HttpDelete("{orderId:guid:required}")]
        public async Task<IActionResult> DeleteOrder([FromRoute] Guid orderId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var res = await _ordersService.DeleteOrder(orderId);
            return res ? Ok("Order Cancelled") : BadRequest("Couldn't Cancel Order");
        }
    }
}
