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
        private readonly ILogger<StoreController> _logger;

        public StoreController(IStoreRepository storeRepository, ILogger<StoreController> logger)
        {
            _storeRepository = storeRepository;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetStoresEnumAsync()
        {
            _logger.LogInformation("GetStoresEnumAsync hitted..");
            return Ok(await _storeRepository.GetStoresEnumAsync());
        }
    }
}
