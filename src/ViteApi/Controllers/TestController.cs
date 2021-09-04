using Microsoft.AspNetCore.Mvc;

namespace ViteApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Test result");
        }
    }
}
