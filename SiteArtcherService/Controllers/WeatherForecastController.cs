
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SiteArcherService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            string teste = "testando conflitos em ambientes com mesmo codigo.";
            return NoContent();
        }

    }
}