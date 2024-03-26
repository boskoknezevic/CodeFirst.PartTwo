using CodeFirst.PartTwo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.PartTwo.Interfaces
{
    public interface IEngineTypeRepository
    {
        public int CreateEngineType(EngineType engineType);
        public void DeleteEngineType(EngineType engineType);
        public List<EngineType> ListAllEngineTypes();
        public int UpdateEngineType(EngineType engineType);
    }
}
