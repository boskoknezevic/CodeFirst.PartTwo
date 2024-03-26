using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Services.Interfaces
{
    public interface ICarServices
    {
        public int CreateCar(Models.Car car);
        public List<Models.Car> ListAllCars();
        public int UpdateCars(Models.Car car);
        public void DeleteCars(Models.Car car);

    }
}
