using Microsoft.AspNetCore.Mvc;

namespace ViteApi.Controllers
{
    public class TestController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Test result");
        }
    }
}
