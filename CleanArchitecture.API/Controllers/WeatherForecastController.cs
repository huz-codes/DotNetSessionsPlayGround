using CleanArchitecture.API.Contracts;
using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces;
using CleanArchitecture.Infrastracture.Brokers;
using CleanArchitecture.Infrastracture.Factories;
using CleanArchitecture.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.API.Controllers
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
        private readonly ICarServices _services;
        private readonly IDependencyInjectionUser _dependencyInjectionUser;
        private readonly IDependencyInjectionDepartment _dependencyInjectionDepartment;
        private readonly IMainBroker _mainBroker;

        private readonly ICircularDependency _circularDependency;
        private readonly IConfiguration _configuration;
        public WeatherForecastController(ILogger<WeatherForecastController> logger,
                                         ICarServices services,
                                         IDependencyInjectionUser dependencyInjectionUser,
                                         IDependencyInjectionDepartment dependencyInjectionDepartment,
                                         ICircularDependency circularDependency,
                                         IMainBroker mainBroker,
                                         IConfiguration configuration)
        {
            _logger = logger;
            _services = services;
            _dependencyInjectionUser = dependencyInjectionUser;
            _dependencyInjectionDepartment = dependencyInjectionDepartment;
            _circularDependency = circularDependency;
            _mainBroker = mainBroker;
            _configuration = configuration;
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

        [HttpPost("/testing")]
        public async Task<ActionResult<CarsContract>> CreateNew([FromBody] CarsOperationsContract model)
        {
            var oDataModel = new Cars()
            {
                CarName = model.CarName,
            };
            var oResult = await _services.Create(oDataModel);
            var oDataResult = new CarsContract()
            {
                CarName = oResult.CarName
            };
            return Ok(oDataResult);
        }


        [HttpPost("/dependencyInjection/{userId}")]
        public IActionResult User(Guid userId)
        {
            var userContent = _circularDependency.GetUserDepartmentNameAndUserNameByUserId(userId);
            return Ok(userContent);
        }

        [HttpPost("/factory")]
        public IActionResult FactoryBuilder()
        {
            var dbContext = DbContextFactory.ContextBuilder("Graph");
            return Ok(dbContext.GetDbContextBasedOnType());
        }

        [HttpPost("/broker")]
        public IActionResult Broker(string url, string content)
        {
            var oMobile = new MobileModel();
            var oGet = _mainBroker.Get(url);
            var oDelete = _mainBroker.Delete(url, string.Empty);
            var oPost = _mainBroker.Post(url, oMobile);
            var oPut = _mainBroker.Put(url, content);

            return Ok($"Get :{oGet}  Delete :{oDelete}  Post :{oPost}  Put :{oPut}");
        }

        [HttpPost("/brokerCreate")]
        public async Task<IActionResult> externalService([FromBody] MobileModel model)
        {
            var oResult = await _mainBroker.Post(_configuration["ExternalAPI"], model);
            return Ok(oResult);
        }

        [HttpGet("/brokerRead")]
        public async Task<IActionResult> getExternalService()
        {
            var oResult = await _mainBroker.Get(_configuration["ExternalAPI"]);
            return Ok(oResult);
        }

        [HttpGet("/brokerRead/{id}")]
        public async Task<IActionResult> getExternalService(int id)
        {
            var oResult = await _mainBroker.Get(_configuration["ExternalAPI"], id);
            return Ok(oResult);
        }

        [HttpDelete("/brokerDelete/{id}")]
        public async Task<IActionResult> deleteExternalService(string id)
        {
            var oResult = await _mainBroker.Delete(_configuration["ExternalAPI"], id);

            return Ok(oResult ? "mobile object deleted successfully" : "something went wrong!");
        }


    }
}