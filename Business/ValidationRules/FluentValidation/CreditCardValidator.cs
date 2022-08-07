using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CreditCardValidator:AbstractValidator<CreditCard>
    {
        public CreditCardValidator()
        {
            RuleFor(p => p.CardNumber).Length(16).WithMessage("Kart numarası 16 haneli olmalıdır!");
            RuleFor(p => p.CVV).Length(3).WithMessage("CVV 3 haneli olmalı!");
            RuleFor(p => p.ExpirationDate).GreaterThanOrEqualTo(NowDate()).WithMessage("Tarihi geçmiş bir kart ekleyemezsiniz!");
        }

        private string NowDate()
        {
            var date = DateTime.Now.ToString("yyyy-MM");
            return date;
        }
    }
}
