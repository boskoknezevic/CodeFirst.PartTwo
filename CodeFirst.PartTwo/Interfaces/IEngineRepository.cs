using CodeFirst.PartTwo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.PartTwo.Interfaces
{
    public interface IEngineRepository
    {
        public int CreateEngine(Engine engine);
        public void DeleteEngine(Engine engine);
        public List<Engine> ListAllEngines();
        public int UpdateEngine(Engine engine);
    }
}
