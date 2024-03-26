using CodeFirst.PartTwo.Interfaces;
using CodeFirst.PartTwo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.PartTwo.Repository
{
    public class EngineRepository : IEngineRepository
    {
        private CarContext _carContext;

        public EngineRepository(CarContext carContext)
        {
            _carContext = carContext;
        }

        public int CreateEngine(Engine engine)
        {
            _carContext.Engines.Add(engine);
            _carContext.SaveChanges();

            return engine.EngineId;
        }


        public void DeleteEngine(Engine engine)
        {
            _carContext.Remove(engine);
            _carContext.SaveChanges();
        }

        public List<Engine> ListAllEngines()
        {
            var engines = _carContext.Engines.ToList();
            return engines;
        }

        public int UpdateEngine(Engine engine)
        {
            var foundEngine = _carContext.Engines.Find(engine.EngineId);
            if (foundEngine != null)
            {
                foundEngine.Year = engine.Year;
                foundEngine.Brand = engine.Brand;
                foundEngine.SerialNumber = engine.SerialNumber;
                foundEngine.Type = engine.Type;
                _carContext.SaveChanges();
            }

            return foundEngine.EngineId;
        }
    }
}
