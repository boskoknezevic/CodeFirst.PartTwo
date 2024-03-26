using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Services.ExternalAPI.DeserializeJSON
{
    public class CarModel
    {
        public int id { get; set; }
        public int make_id { get; set; }
        public string name { get; set; }
        public Make make { get; set; }
    }
}
