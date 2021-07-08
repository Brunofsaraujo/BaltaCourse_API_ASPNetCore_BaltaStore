using Microsoft.AspNetCore.Mvc;

namespace BaltaStore.Api.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("v1/home")]
        public object Get()
        {
            return new { version = "Version 0.0.1" };
        }
    }
}