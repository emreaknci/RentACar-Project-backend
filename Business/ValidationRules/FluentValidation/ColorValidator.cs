using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidator: AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("Renk adı boş bırakılamaz.");
            RuleFor(c => c.Name).MinimumLength(3).WithMessage("Renk adı minmum 3 haneli olmalı.");
        }
    }
}
