using Core.DTOs.UserInfo;
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
        
        [HttpGet("GetOrderById/{Id}")]
        public async Task<IActionResult> GetOrderByIdAsync(string Id, int page)
        {
            var result = await _order.GetOrderByIdAsync(Id, page);
            if (result != null)
            {
                return Ok(result);
            }
            return Ok();
        }
        
        [HttpGet("GetCountOrderById/{Id}")]
        public async Task<IActionResult> GetCountOrderByIdAsync(string Id)
        {
            var result = await _order.GetCountOrderByIdAsync(Id);
            if (result != null)
            {
                return Ok(result);
            }
            return Ok();
        }
    }
}
