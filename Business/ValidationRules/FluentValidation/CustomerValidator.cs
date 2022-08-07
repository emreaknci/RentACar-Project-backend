using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator: AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(p => p.CompanyName).NotEmpty().WithMessage("Şirket adı alanı boş bırakılamaz.")
                .MinimumLength(3).WithMessage("Şirket adı minimum 3 karakterden oluşmalı.");
        }
    }
}
