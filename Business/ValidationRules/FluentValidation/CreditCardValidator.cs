using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CreditCardValidator:AbstractValidator<CreditCard>
    {
        public CreditCardValidator()
        {
            RuleFor(p => p.CardNumber).MinimumLength(16).MaximumLength(16);
            RuleFor(p => p.CVV).MinimumLength(3).MaximumLength(3);
        }
    }
}
