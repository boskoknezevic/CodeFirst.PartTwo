using CodeFirst.PartTwo.Interfaces;
using CodeFirst.PartTwo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.PartTwo.Repository
{
    public class CarRepository : ICarRepository
    {
        private CarContext _carContext;

        public CarRepository(CarContext carContext)
        {
            _carContext = carContext;
        }

        public int CreateCar(Car car)
        {
            _carContext.Cars.Add(car);
            _carContext.SaveChanges();

            return car.CarId;
        }

        public void DeleteCar(Car car)
        {
            _carContext.Remove(car);
            _carContext.SaveChanges();
        }

        public List<Car> ListAllCars()
        {
            var cars = _carContext.Cars.ToList();
            return cars;
        }

        public int UpdateCar(Car car)
        {
            var foundCar = _carContext.Cars.Find(car.CarId);
            if (foundCar != null)
            {
                foundCar.ChassisNumber = car.ChassisNumber;
                foundCar.Model = car.Model;
                foundCar.Color = car.Color;
                foundCar.Brand = car.Brand;
                foundCar.Year = car.Year;
                _carContext.SaveChanges();
            }
            
            return foundCar.CarId;
        }
    }
}
