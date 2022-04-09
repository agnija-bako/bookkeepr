using Microsoft.AspNetCore.Mvc;
using DataModels.Models;

namespace Bookkeepr.Controllers
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

        [HttpGet(Name = "GetDefaultUser")]
        public User Get()
        {
            return new User { Email = "agnijabako@gmail.com", Id = 1, Name = "Agnija Bako" };    
        }
    }
}