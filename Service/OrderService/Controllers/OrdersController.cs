using Microsoft.AspNetCore.Mvc;

namespace OrdersService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetHello()
        {
            return Ok(new[] { "Order 1", "Order 2", "Order 3" });
        }
    }
}