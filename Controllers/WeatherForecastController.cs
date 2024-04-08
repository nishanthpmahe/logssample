using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SentrySampleApp.Controllers
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

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
            })
            .ToArray();
        }

        [HttpGet("/person/{id}")]
        public IActionResult Person(string id)
        {
            int i = 0;

            try
            {
                _logger.LogInformation("Processing request for person {id}", id);
                // Do the work that gets measured.
                int j = 1 / i;

            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while processing the request.");
                throw;
            }

            return Ok();
        }
    }
}
