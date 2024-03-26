using CodeFirst.PartTwo.Interfaces;
using CodeFirst.PartTwo.Repository;
using CodeFirst.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Services.Services
{
    public class EngineServices : IEngineServices
    {
        private IEngineRepository _engineRepository;

        public EngineServices (IEngineRepository engineRepository)
        {
            _engineRepository = engineRepository;
        }

        public int CreateEngine(Models.Engine engine)
        {
            PartTwo.Models.Engine newEngine = new PartTwo.Models.Engine();
            newEngine.Year = engine.Year;
            newEngine.Brand = engine.Brand;
            newEngine.SerialNumber = engine.SerialNumber;
            newEngine.Type = engine.Type;
            return _engineRepository.CreateEngine(newEngine);
        }

        public void DeleteEngine(Models.Engine engine)
        {
            PartTwo.Models.Engine newEngine = new PartTwo.Models.Engine();
            newEngine.EngineId = engine.EngineId;
            newEngine.Year = engine.Year;
            newEngine.Brand = engine.Brand;
            newEngine.SerialNumber = engine.SerialNumber;
            newEngine.Type = engine.Type;

            _engineRepository.DeleteEngine(newEngine);
        }

        public List<Models.Engine>ListAllEngines() 
        { 
            var allEngines = _engineRepository.ListAllEngines();

            List<Models.Engine> newEngines = new List<Models.Engine>();

            foreach (var engine in allEngines)
            {
                Models.Engine newEngine = new Models.Engine();
                newEngine.Year = engine.Year;
                newEngine.Brand = engine.Brand;
                newEngine.SerialNumber = engine.SerialNumber;
                newEngine.Type = engine.Type;

                newEngines.Add(newEngine);
            }

            return newEngines;
        }

        public int UpdateEngines(Models.Engine engine)
        {
            PartTwo.Models.Engine newEngine = new PartTwo.Models.Engine();
            newEngine.EngineId = engine.EngineId;
            newEngine.Year = engine.Year;
            newEngine.Brand = engine.Brand;
            newEngine.SerialNumber = engine.SerialNumber;
            newEngine.Type = engine.Type;

            return _engineRepository.UpdateEngine(newEngine);
        }

    }
}
