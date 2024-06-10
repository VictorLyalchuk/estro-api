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
        [HttpGet("GetOrderByEmail/{email}")]
        public async Task<IActionResult> GetOrderByEmailAsync(string email, int page)
        {
            var result = await _order.GetOrderByEmailAsync(email, page);
            if (result != null)
            {
                return Ok(result);
            }
            return Ok();
        }
        [HttpGet("GetCountOrderByEmail/{email}")]
        public async Task<IActionResult> GetCountOrderByEmailAsync(string email)
        {
            var result = await _order.GetCountOrderByEmailAsync(email);
            if (result != null)
            {
                return Ok(result);
            }
            return Ok();
        }
    }
}
