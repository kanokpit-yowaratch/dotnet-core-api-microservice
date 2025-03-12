using Microsoft.AspNetCore.Mvc;

namespace ProductService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetHello()
        {
            return Ok(new[] { "Product 1", "Product 2", "Product 3" });
        }
    }
}