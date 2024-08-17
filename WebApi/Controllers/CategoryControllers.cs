using Core.DTOs.Category;
using Core.DTOs.Product;
using Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
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
        public async Task<IActionResult> MainCategoryGetAsync()
        {
            return Ok(await _category.MainGetAllAsync());
        }

        [HttpGet("SubCategoryGetAsync")]
        public async Task<IActionResult> SubCategoryGetAsync()
        {
            return Ok(await _category.SubGetAllAsync());
        }

        [HttpGet("CategoryGetAsync")]
        public async Task<IActionResult> CategoryGetAllAsync()
        {
            return Ok(await _category.CategoryGetAllAsync());
        }

        [HttpGet("CategoryGetWithSub")]
        public async Task<IActionResult> CategoryGetWithSubAsync([FromQuery] string subName)
        {
            return Ok(await _category.CategoryGetWithSubAsync(subName));
        }

        [HttpGet("MainCategoryByPage/{page}")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> MainCategoryByPageAsync(int page)
        {
            var mainCategory = await _category.MainCategoryByPageAsync(page);
            if (mainCategory == null)
            {
                return NotFound();
            }
            return Ok(mainCategory);
        }

        [HttpGet("GetMainCategoryById/{id}")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> GetMainCategoryByIdAsync(int id)
        {
            var mainCategory = await _category.GetMainCategoryByIdAsync(id);
            if (mainCategory == null)
            {
                return NotFound();
            }
            return Ok(mainCategory);
        }

        [HttpGet("MainCategoryQuantity")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> MainCategoryQuantityAsync()
        {
            var quantity = await _category.MainCategoryQuantityAsync();
            return Ok(quantity);
        }

        [HttpPost("CreateMainCategory")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> CreateMainCategoryAsync(CreateMainCategoryDTO createMainCategoryDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _category.CreateMainCategoryAsync(createMainCategoryDTO);
            return Ok();
        }

        [HttpPost("EditMainCategory")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> EditMainCategoryAsync(EditMainCategoryDTO editMainCategoryDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _category.EditMainCategoryAsync(editMainCategoryDTO);
            return Ok();
        }

        [HttpDelete("DeleteMainCategoryByID/{id}")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteMainCategoryByIDAsync(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _category.DeleteMainCategoryByIDAsync(id);
            return Ok();
        }
    }
}
