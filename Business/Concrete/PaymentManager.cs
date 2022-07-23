using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PaymentManager : IPaymentService
    {
        private readonly IPaymentDal _paymentDal;

        public PaymentManager(IPaymentDal paymentDal)
        {
            _paymentDal = paymentDal;
        }

        [ValidationAspect(typeof(CreditCardValidator))]
        public IResult Add(CreditCard creditCard)
        {
            _paymentDal.Add(creditCard);
            return new SuccessResult(Messages.CardAdded);
        }

        [ValidationAspect(typeof(CreditCardValidator))]
        public IResult Update(CreditCard creditCard)
        {
            _paymentDal.Update(creditCard);
            return new SuccessResult(Messages.CardUpdated);
        }

        public IResult Delete(CreditCard creditCard)
        {
            _paymentDal.Delete(creditCard);
            return new SuccessResult(Messages.CardDeleted);
        }

        public IDataResult<List<CreditCard>> GetAll()
        {
            return new SuccessDataResult<List<CreditCard>>(_paymentDal.GetAll(),Messages.CardsListed);
        }

        public IDataResult<CreditCard> GetById(int id)
        {
            return new SuccessDataResult<CreditCard>(_paymentDal.Get(p => p.Id == id));
        }

        public IDataResult<CreditCard> GetByCardNumber(string cardNumber)
        {
            return new SuccessDataResult<CreditCard>(_paymentDal.Get(p => p.CardNumber == cardNumber), "geldi");
        }

        public IDataResult<CreditCard> GetByCustomerId(int id)
        {
            return new SuccessDataResult<CreditCard>(_paymentDal.Get(p => p.CustomerId==id));

        }
    }
}
