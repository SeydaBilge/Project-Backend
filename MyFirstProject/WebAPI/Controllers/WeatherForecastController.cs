using Microsoft.AspNetCore.Mvc;
//gelen t�m istekleri kar��lar
//bize yap�labilecek istekleri kodlar�z
//httpget iste�inde bulunabilir
//controller, bizim sistemimizi kullanacak client'lar ->taray�c�,mobiluygulama
//clietlar bize hangi operasyonlar i�in ve nas�l istekte bulunabilirleri burada yaz�l�r
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