using CodeFirst.Services.Interfaces;
using CodeFirst.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirst.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EngineTypeController :ControllerBase
    {
        private readonly IEngineTypeServices _engineTypeServices;

        public EngineTypeController(IEngineTypeServices engineTypeServices)
        {
            _engineTypeServices = engineTypeServices;
        }

        [HttpGet]
        public IActionResult ListAllEngines()
        {
            var engineTypes = _engineTypeServices.ListAllEngineTypes();
            return Ok(engineTypes);
        }

        [HttpPost]
        public IActionResult CreateNewEngineType(Models.EngineType engineType)
        {
            Services.Models.EngineType newEngineType = new Services.Models.EngineType();
            newEngineType.Model = engineType.Model;
            newEngineType.Name = engineType.Name;

            return Ok(_engineTypeServices.CreateEngineType(newEngineType));
        }


        [HttpDelete]
        public IActionResult DeleteEngineType(Models.EngineType engineType)
        {
            Services.Models.EngineType newEngineType = new Services.Models.EngineType();
            newEngineType.EngineTypeId = engineType.EngineTypeId;
            newEngineType.Model = engineType.Model;
            newEngineType.Name = engineType.Name;
            _engineTypeServices.DeleteEngineType(newEngineType);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateEngineType(Models.EngineType engineType)
        {
            Services.Models.EngineType newEngineType = new Services.Models.EngineType();
            newEngineType.EngineTypeId = engineType.EngineTypeId;
            newEngineType.Model = engineType.Model;
            newEngineType.Name = engineType.Name;
            _engineTypeServices.UpdateEngineTypes(newEngineType);
            return Ok();
        }
    }
}
