using APIBase.Base.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APIBase.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IJsonResponse _response;

        public HomeController(IJsonResponse response)
        {
            _response = response;
        }

        [HttpGet]
        public JsonResult Get()
            => _response.Ok(new
            {
                Nombre = "Darwin",
                Apellido = "Hernández"
            }, "Solicitud exitosa");
    }
}