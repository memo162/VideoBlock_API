using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;

namespace VideoBlock_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IPeliculasApplication _peliculaApplication;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,
            IPeliculasApplication peliculaApplication)
        {
            _logger = logger;
            _peliculaApplication = peliculaApplication;
        }

        [HttpGet]
        public Pelicula Get()
        {
            //var rng = new Random();
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = rng.Next(-20, 55),
            //    Summary = Summaries[rng.Next(Summaries.Length)]
            //})
            //.ToArray();

            //var provider = new PeliculaProvider(new PeliculaContext("Server=DESKTOP-9VHHK9S\\SQLEXPRESS;Database=VideoBlock;User ID=DESKTOP-9VHHK9S\\Admin;Trusted_Connection=True;MultipleActiveResultSets=true"));
            //var pelicula = provider.Get(1);
            //return pelicula;

            return _peliculaApplication.Get(1);
        }
    }
}
