using CodeFirst.Services.ExternalAPI;
using CodeFirst.Services.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Services.Validator
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator() 
        {
            RuleFor(car => car).MustAsync( (car, CancellationToken) => ValidateModel(car.Year, car.Brand, car.Model))
                                .WithMessage("Model is not valid for the given brand and year!");
        }

        public async Task<bool> ValidateModel(int year, string brand, string model)
        {
            bool isTrue = false;
            CarAPI carAPI = new CarAPI();
            List<string> models = await carAPI.CallExternalAPI(year, brand);
            foreach (var modelItem in models)
            {
                if (modelItem == model)
                    isTrue = true;
            }

            return isTrue;
        }
    }
}
