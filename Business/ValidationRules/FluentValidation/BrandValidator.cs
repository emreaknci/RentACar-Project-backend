using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator: AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(b => b.Name).NotEmpty().WithMessage("Marka adı boş bırakılamaz");
            RuleFor(p => p.Name).MinimumLength(3).WithMessage("Marka adı minimum 3 Karakter olmalı");
        }
    }
}
