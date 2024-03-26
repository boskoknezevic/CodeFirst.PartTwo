using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.PartTwo.Models
{
    public class Engine
    {
        public int EngineId {  get; set; }
        public int Year {  get; set; }
        public string Brand { get; set; }
        public string SerialNumber { get; set; }
        public string Type { get; set; }

        [ForeignKey("Car")]
        public int? CarId { get; set; }
        public Car Car { get; set; }

        [ForeignKey("EngineType")]
        public int? EngineTypeId { get; set; }
        public EngineType EngineType { get; set; }
    }
}
