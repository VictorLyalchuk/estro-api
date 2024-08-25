using Core.DTOs.UserInfo;
using Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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

        // CRUD Store
        [HttpGet("OrderByPage/{page}")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> OrderByPageAsync(int page, [FromQuery] int pageSize, string step)
        {
            var stepArray = JsonConvert.DeserializeObject<int[]>(step);
            var orders = await _order.OrderByPageAsync(page, pageSize, stepArray);
            if (orders == null)
            {
                return NotFound();
            }
            return Ok(orders);
        }

        [HttpGet("OrderQuantity")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> OrderQuantityAsync([FromQuery] string step)
        {
            var stepArray = JsonConvert.DeserializeObject<int[]>(step);
            var quantity = await _order.OrderQuantityAsync(stepArray);
            return Ok(quantity);
        }

        [HttpPost("EditOrderItems")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> EditOrderItemsAsync(OrderItemsDTO orderItemsDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _order.EditOrderItemsAsync(orderItemsDTO);
            return Ok();
        }
    }
}
