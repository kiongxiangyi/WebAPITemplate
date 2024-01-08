using Microsoft.AspNetCore.Mvc;

namespace EmptyTemplate.Controllers
{
    public class HomeController : ControllerBase
    {
        [HttpGet("/")]
        public IActionResult Index()
        {
            return Ok("Hello World");
        }
    }
}
