using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfoController : Controller
    {
        private readonly IInfoService _info;
        public InfoController(IInfoService info)
        {
            _info = info;
        }
        [HttpGet("GetInfo")]
        public async Task<IActionResult> GetInfoAsync()
        {
            var filters = await _info.GetInfoAsync();
            if (filters == null)
            {
                return NotFound();
            }
            return Ok(filters);
        }
    }
}
