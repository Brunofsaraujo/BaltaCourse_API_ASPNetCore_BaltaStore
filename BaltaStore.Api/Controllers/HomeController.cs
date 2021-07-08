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

        [HttpGet]
        [Route("v1/error")]
        public string Error()
        {
            throw new System.Exception("Algum erro ocorreu");
            return "Erro";
        }
    }
}