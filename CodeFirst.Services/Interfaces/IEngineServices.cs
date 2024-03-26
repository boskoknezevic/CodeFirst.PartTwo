using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Services.Interfaces
{
    public interface IEngineServices
    {
        public int CreateEngine(Models.Engine engine);
        public void DeleteEngine(Models.Engine engine);
        public List<Models.Engine> ListAllEngines();
        public int UpdateEngines(Models.Engine engine);

    }
}
