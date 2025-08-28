using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace product_api_playground.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult HelloWorldAsync()
        {
            return Ok("Hello world");
        }
    }
}
