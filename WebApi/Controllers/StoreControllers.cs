using Core.DTOs.Store;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreControllers : Controller
    {
        private readonly IStoreService _store;
        private readonly IAddressService _address;
        public StoreControllers(IStoreService store, IAddressService address)
        {
            _store = store;
            _address = address;
        }

        [HttpPost("CreateStore")]
        public async Task<IActionResult> CreateProduct(CreateStoreDTO createStoreDTO)
        {
            await _store.CreateAsync(createStoreDTO);
            return Ok();
        }
        [HttpDelete("DeleteStore/{id}")]
        public async Task<IActionResult> DeleteStoreAsync(int id)
        {
            await _store.DeleteAsync(id);
            return Ok();
        }

        [HttpPost("EditStore")]
        public async Task<IActionResult> EditProduct(EditStoreDTO editStoreDTO)
        {
            await _store.EditAsync(editStoreDTO);
            return Ok();
        }
        [HttpGet("StoreByPage")]
        public async Task<IActionResult> StoreByPage(int page)
        {
            var stores = await _store.GetAllByPageAsync(page);
            if (stores == null)
            {
                return NotFound();
            }
            return Ok(stores);
        }
        [HttpGet("StoreAll")]
        public async Task<IActionResult> StoreAll()
        {
            var stores = await _store.GetAllAsync();
            if (stores == null)
            {
                return NotFound();
            }
            return Ok(stores);
        }
        [HttpGet("StoreById")]
        public async Task<IActionResult> StoreById(int id)
        {
            var store = await _store.GetStoreByIDAsync(id);
            if (store == null)
            {
                return NotFound();
            }
            return Ok(store);
        }
        [HttpGet("getCountry")]
        public async Task<IActionResult> GetCountry()
        {
            var country = await _address.GetCountry();
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }
        [HttpGet("getCity")]
        public async Task<IActionResult> getCity()
        {
            var city = await _address.GetCity();
            if (city == null)
            {
                return NotFound();
            }
            return Ok(city);
        }
    }
}
