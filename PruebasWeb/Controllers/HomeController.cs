using Microsoft.AspNetCore.Mvc;
using PruebasWeb.Servicios;

namespace PruebasWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IServicioCalculadora _servicio;

        public HomeController(ILogger<HomeController> logger,
                              IServicioCalculadora servicio)
        {
            _logger = logger;
            this._servicio = servicio;
        }

        public IActionResult Index()
        {
            return Ok();
        }
    }
}