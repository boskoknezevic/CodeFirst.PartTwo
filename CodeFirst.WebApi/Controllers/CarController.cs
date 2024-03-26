using CodeFirst.Services.ExternalAPI;
using CodeFirst.Services.Interfaces;
using CodeFirst.Services.Models;
using CodeFirst.WebApi.Models;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CodeFirst.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ICarServices _carServices;
        private readonly IValidator<Services.Models.Car> _validator;

        public CarController(ICarServices carServices, IValidator<Services.Models.Car> validator)
        {
            _carServices = carServices;
            _validator = validator;
        }

        [HttpGet]
        public IActionResult ListAllCars()
        {
            var cars = _carServices.ListAllCars();
            return Ok(cars);
        }

        [HttpPost]
        public async Task<IActionResult> Create(WebApi.Models.Car car)
        {
            Services.Models.Car newCar = new Services.Models.Car();

                newCar.Year = car.Year;
                newCar.ChassisNumber = car.ChassisNumber;
                newCar.Brand = car.Brand;
                newCar.Color = car.Color;
                newCar.Model = car.Model;

            var contextValidator = new ValidationContext<Services.Models.Car>(newCar);
            ValidationResult result = await _validator.ValidateAsync(contextValidator);

            if (result.IsValid)
            {
                

                return Ok(_carServices.CreateCar(newCar));
            }
            else return BadRequest();
        }

        [HttpDelete]
        public IActionResult DeleteCar(Models.Car car)
        {
            Services.Models.Car newCar = new Services.Models.Car();
            newCar.CarId = car.CarId;
            newCar.Year = car.Year;
            newCar.ChassisNumber = car.ChassisNumber;
            newCar.Brand = car.Brand;
            newCar.Color = car.Color;
            newCar.Model = car.Model;
            _carServices.DeleteCars(newCar);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateCar(Models.Car car)
        {
            Services.Models.Car newCar = new Services.Models.Car();
            newCar.CarId = car.CarId;
            newCar.Year = car.Year;
            newCar.ChassisNumber = car.ChassisNumber;
            newCar.Brand = car.Brand;
            newCar.Color = car.Color;
            newCar.Model = car.Model;
            _carServices.UpdateCars(newCar);
            return Ok();
        }
    }
}
