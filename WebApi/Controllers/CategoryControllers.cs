using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryControllers : Controller
    {
        private readonly ICategoryService _category;
        public CategoryControllers(ICategoryService category)
        {
            _category = category;
        }

        [HttpGet("MainCategoryGetAsync")]
        public async Task <IActionResult> MainCategoryGetAsync()
        {
            return Ok(await _category.MainGetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task <IActionResult> MainCategoryGetByIdAsync(int id)
        {
            return Ok(await _category.MainGetByIdAsync(id));
        }

        [HttpGet("SubCategoryGetAsync")]
        public async Task<IActionResult> SubCategoryGetAsync()
        {
            return Ok(await _category.SubGetAllAsync());
        }

        [HttpGet("CategoryGetAsync")]
        public async Task<IActionResult> CategoryGetAllAsync()
        {
            return Ok(await _category.GetAllAsync());
        }

        [HttpGet("CategoryGetWithSub")]
        public async Task<IActionResult> CategoryGetWithSubAsync([FromQuery] string subName)
        {
            return Ok(await _category.CategoryGetWithSubAsync(subName));
        }
    }
}
