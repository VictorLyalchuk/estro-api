using Core.DTOs.Information;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderControllers : Controller
    {
        private readonly IOrderService _order;
        public OrderControllers(IOrderService order)
        {
            _order = order;
        }
        [HttpPost("CreateOrder")]
        public async Task<IActionResult> CreateProductAsync(OrderCreateDTO orderCreateDTO)
        {
            await _order.CreateAsync(orderCreateDTO);
            return Ok();
        }
        [HttpGet("GetAllOrders")]
        public async Task<IActionResult> GetAllOrdersAsync()
        {
            var result = await _order.GetAllOrdersAsync();
            if (result != null)
            {
                return Ok(result);
            }
            return Ok();
        }
        [HttpGet("GetOrderByEmail")]
        public async Task<IActionResult> GetOrderByEmailAsync(string email)
        {
            var result = await _order.GetOrderByEmailAsync(email);
            if (result != null)
            {
                return Ok(result);
            }
            return Ok();
        }
    }
}
