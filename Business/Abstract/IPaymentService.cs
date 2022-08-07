using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IPaymentService
    {
        IResult Add(CreditCard creditCard);
        IResult Update(CreditCard creditCard);
        IResult Delete(CreditCard creditCard);
        IDataResult<List<CreditCard>> GetAll();
        IDataResult<CreditCard> GetById(int id);
        IDataResult<CreditCard> GetByCardNumber(string cardNumber);
        IDataResult<List<CreditCard>> GetByCustomerId(int id);
        IDataResult<List<CreditCard>> GetByCustomerMail(string email);

    }
}
