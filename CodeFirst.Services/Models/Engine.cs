using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Services.Models
{
    public class Engine
    {
        public int EngineId { get; set; }
        public int Year { get; set; }
        public string Brand { get; set; }
        public string SerialNumber { get; set; }
        public string Type { get; set; }
    }
}
