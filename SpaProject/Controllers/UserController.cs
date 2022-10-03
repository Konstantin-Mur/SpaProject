using Microsoft.AspNetCore.Mvc;
using SpaProject.Models;

namespace SpaProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetUser")]
        public User GetUser(Guid id)
        {
            throw new ArgumentException();
            //return Enumerable.Range(1, 5).Select(index => new User
            //{
            //    DateCreate = DateTime.Now.AddDays(index),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();
        }
    }
}