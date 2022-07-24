using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Description).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0).NotEmpty();
            RuleFor(c => c.ColorId).NotEmpty();
            RuleFor(c => c.BrandId).NotEmpty();
            RuleFor(c => c.ModelYear).NotEmpty().GreaterThan(1890).WithMessage("Model yılı 1890'dan öncesi olamaz")
                .LessThanOrEqualTo(DateTime.Now.Year).WithMessage("Model yılı "+DateTime.Now.Year+" yılından sonrası olamaz");
        }


    }
}
