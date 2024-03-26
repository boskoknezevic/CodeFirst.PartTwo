using CodeFirst.PartTwo.Interfaces;
using CodeFirst.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Services.Services
{
    public class EngineTypeServices : IEngineTypeServices
    {
        private IEngineTypeRepository _engineTypeRepository;

        public EngineTypeServices (IEngineTypeRepository engineTypeRepository)
        {
            _engineTypeRepository = engineTypeRepository;
        }

        public int CreateEngineType (Models.EngineType engineType)
        {
            PartTwo.Models.EngineType newEngineType = new PartTwo.Models.EngineType();
            newEngineType.Model = engineType.Model;
            newEngineType.Name = engineType.Name;
            return _engineTypeRepository.CreateEngineType (newEngineType);
        }

        public void DeleteEngineType (Models.EngineType engineType)
        {
            PartTwo.Models.EngineType newEngineType = new PartTwo.Models.EngineType();
            newEngineType.EngineTypeId = engineType.EngineTypeId;
            newEngineType.Model = newEngineType.Model;
            newEngineType.Name = newEngineType.Name;

            _engineTypeRepository.DeleteEngineType (newEngineType);
        }

        public List<Models.EngineType> ListAllEngineTypes () 
        {
            var allEngineTypes = _engineTypeRepository.ListAllEngineTypes();

            List<Models.EngineType> newEngineTypes = new List<Models.EngineType>();

            foreach (var engineType in allEngineTypes) 
            {
                Models.EngineType newEngineType = new Models.EngineType();
                newEngineType.Model = engineType.Model;
                newEngineType.Name= engineType.Name;

                newEngineTypes.Add (newEngineType);
            }

            return newEngineTypes;
        }

        public int UpdateEngineTypes (Models.EngineType engineType)
        {
            PartTwo.Models.EngineType newEngineType = new PartTwo.Models.EngineType();
            newEngineType.EngineTypeId = engineType.EngineTypeId;
            newEngineType.Model = engineType.Model;
            newEngineType.Name = engineType.Name;

            return _engineTypeRepository.UpdateEngineType(newEngineType);
        }
    }
}
