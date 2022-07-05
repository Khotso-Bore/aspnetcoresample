using Microsoft.AspNetCore.Mvc;

namespace aspnetapp.Controller
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok(new {message = "hello"});
        }
    }
}
