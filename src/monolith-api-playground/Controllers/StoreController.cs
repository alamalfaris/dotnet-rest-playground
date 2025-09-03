using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using monolith_api_playground.Repositories;

namespace monolith_api_playground.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly IStoreRepository _storeRepository;

        public StoreController(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }

        [HttpGet("enum")]
        public async Task<IActionResult> GetStoresEnumAsync()
        {
            return Ok(await _storeRepository.GetStoresEnumAsync());
        }

        [HttpGet("list")]
        public async Task<IActionResult> GetStoresListAsync()
        {
            return Ok(await _storeRepository.GetStoresListAsync());
        }
    }
}
