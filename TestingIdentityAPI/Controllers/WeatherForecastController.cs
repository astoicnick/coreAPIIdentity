using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TestingIdentityAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        private readonly UserManager<WholeAppUser> _userManager;
        private readonly SignInManager<WholeAppUser> _signInManager;

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, UserManager<WholeAppUser> userManager, SignInManager<WholeAppUser> signInManager)
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IEnumerable<WholeAppUser> Get()
        {
            //var rng = new Random();
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = rng.Next(-20, 55),
            //    Summary = Summaries[rng.Next(Summaries.Length)]
            //})
            //.ToArray();
            return _userManager.Users.ToList();
        }
        [HttpPost]
        [Route("Register")]
        public async Task<string> Register(string email, string userName, string password)
        {
            var createRes = await _userManager.CreateAsync(new WholeAppUser()
            {
                Email = email,
                UserName = userName
            },
                password);
            if (createRes.Succeeded)
            {
            return "Registered!";
            }
            else
            {
                return createRes.Errors.ToList().ToString();
            }
        }
    }
}
