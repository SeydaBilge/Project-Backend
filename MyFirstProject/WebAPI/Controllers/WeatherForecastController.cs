using Microsoft.AspNetCore.Mvc;
//gelen tüm istekleri karþýlar
//bize yapýlabilecek istekleri kodlarýz
//httpget isteðinde bulunabilir
//controller, bizim sistemimizi kullanacak client'lar ->tarayýcý,mobiluygulama
//clietlar bize hangi operasyonlar için ve nasýl istekte bulunabilirleri burada yazýlýr
//view yok controller var restful mimarisinde
namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

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
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}