using CodeFirst.PartTwo.Interfaces;
using CodeFirst.PartTwo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.PartTwo.Repository
{
    public class EngineTypeRepository : IEngineTypeRepository
    {
        private CarContext _carContext;

        public EngineTypeRepository(CarContext carContext)
        {
            _carContext = carContext;
        }

        public int CreateEngineType(EngineType engineType)
        {
            _carContext.EngineTypes.Add(engineType);
            _carContext.SaveChanges();

            return engineType.EngineTypeId;
        }

        public void DeleteEngineType(EngineType engineType)
        {
            _carContext.Remove(engineType);
            _carContext.SaveChanges();
        }

        public List<EngineType> ListAllEngineTypes()
        {
            var engineTypes = _carContext.EngineTypes.ToList();
            return engineTypes;
        }

        public int UpdateEngineType(EngineType engineType)
        {
            var foundEngineType = _carContext.EngineTypes.Find(engineType.EngineTypeId);
            if (foundEngineType != null)
            {
                foundEngineType.Model = engineType.Model;
                foundEngineType.Name = engineType.Name;
                _carContext.SaveChanges();
            }

            return foundEngineType.EngineTypeId;
        }
    }
}
