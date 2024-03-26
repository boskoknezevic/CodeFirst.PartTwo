using CodeFirst.PartTwo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.PartTwo.Interfaces
{
    public interface ICarRepository
    {
        public int CreateCar(Car car);
        public List<Car> ListAllCars();
        public int UpdateCar(Car car);
        public void DeleteCar(Car car);
    }
}
