using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetByCustomerId(int customerId);
        IDataResult<Rental> GetByRentalId(int rentalId);
        IDataResult<Rental> IsRentable(int carId);
        IDataResult<List<RentalDetailsDto>> GetRentalDetails();

        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
    }
}
