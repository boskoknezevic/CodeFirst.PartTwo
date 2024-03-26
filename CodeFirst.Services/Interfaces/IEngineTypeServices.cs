using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Services.Interfaces
{
    public interface IEngineTypeServices
    {
        public int CreateEngineType(Models.EngineType engineType);
        public void DeleteEngineType(Models.EngineType engineType);
        public List<Models.EngineType> ListAllEngineTypes();
        public int UpdateEngineTypes(Models.EngineType engineType);
    }
}
