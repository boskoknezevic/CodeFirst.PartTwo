using CodeFirst.Services.Interfaces;
using CodeFirst.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirst.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EngineController : ControllerBase
    {
        private readonly IEngineServices _engineServices;

        public EngineController(IEngineServices engineServices)
        {
            _engineServices = engineServices;
        }

        [HttpGet]
        public IActionResult ListAllEngines() 
        {
            var engines = _engineServices.ListAllEngines();
            return Ok(engines);
        }
        
        [HttpPost]
        public IActionResult CreateNewEngine(Models.Engine engine)
        {
            Services.Models.Engine newEngine = new Services.Models.Engine();
            newEngine.Year = engine.Year;
            newEngine.Brand = engine.Brand;
            newEngine.SerialNumber = engine.SerialNumber;
            newEngine.Type = engine.Type;
            
            return Ok(_engineServices.CreateEngine(newEngine));
        }

        
        [HttpDelete]
        public IActionResult DeleteEngine(Models.Engine engine)
        {
            Services.Models.Engine newEngine = new Services.Models.Engine();
            newEngine.EngineId = engine.EngineId;
            newEngine.Year = engine.Year;
            newEngine.Brand = engine.Brand;
            newEngine.SerialNumber = engine.SerialNumber;
            newEngine.Type = engine.Type;
            _engineServices.DeleteEngine(newEngine);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateEngine(Models.Engine engine)
        {
            Services.Models.Engine newEngine = new Services.Models.Engine();
            newEngine.EngineId = engine.EngineId;
            newEngine.Year = engine.Year;
            newEngine.Brand = engine.Brand;
            newEngine.SerialNumber = engine.SerialNumber;
            newEngine.Type = engine.Type;
            _engineServices.UpdateEngines(newEngine);
            return Ok();
        }
    }
}
