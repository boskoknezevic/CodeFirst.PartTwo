using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeFirst.Services.ExternalAPI.DeserializeJSON
{
    public class Root
    {
        public Collection collection { get; set; }
        public List<CarModel> data { get; set; }
    }
}
