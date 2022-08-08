using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CountryInfoAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
