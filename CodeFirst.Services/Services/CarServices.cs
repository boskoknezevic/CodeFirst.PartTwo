using CodeFirst.PartTwo.Interfaces;
using CodeFirst.PartTwo.Models;
using CodeFirst.Services.Interfaces;
using CodeFirst.Services.Models;


namespace CodeFirst.Services.Services
{
    public class CarServices : ICarServices
    {
        private ICarRepository _carRepository;

        public CarServices(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public int CreateCar(Models.Car car)
        {
            //

            PartTwo.Models.Car newCar = new PartTwo.Models.Car();
            newCar.Year = car.Year;
            newCar.ChassisNumber = car.ChassisNumber;
            newCar.Brand = car.Brand;
            newCar.Color = car.Color;
            newCar.Model = car.Model;
            return _carRepository.CreateCar(newCar);
        }

        public void DeleteCars(Models.Car car)
        {
            PartTwo.Models.Car newCar = new PartTwo.Models.Car();
            newCar.CarId = car.CarId;
            newCar.Year = car.Year;
            newCar.ChassisNumber = car.ChassisNumber;
            newCar.Brand = car.Brand;
            newCar.Color = car.Color;
            newCar.Model = car.Model;


            _carRepository.DeleteCar(newCar);
        }

        public List<Models.Car> ListAllCars()
        {
            var allCars = _carRepository.ListAllCars();

            List<Models.Car> newCars = new List<Models.Car>();

            

            foreach(var car in allCars)
            {
                Models.Car newCar = new Models.Car();
                newCar.Year = car.Year;
                newCar.ChassisNumber = car.ChassisNumber;
                newCar.Brand = car.Brand;
                newCar.Color = car.Color;
                newCar.Model = car.Model;

                newCars.Add(newCar);
            }
            return newCars;
        }

        public int UpdateCars(Models.Car car)
        {
            PartTwo.Models.Car newCar = new PartTwo.Models.Car();
                newCar.CarId = car.CarId;
                newCar.Year = car.Year;
                newCar.ChassisNumber = car.ChassisNumber;
                newCar.Brand = car.Brand;
                newCar.Color = car.Color;
                newCar.Model = car.Model;

                return _carRepository.UpdateCar(newCar);
        }
    }
}
