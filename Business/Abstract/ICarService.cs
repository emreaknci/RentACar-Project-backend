using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByColorId(int Id);
        IDataResult<List<Car>> GetCarsByBrandId(int Id);
        IDataResult<Car> GetById(int Id);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<List<CarDetailDto>> GetRentalableCarDetails();
        IDataResult<List<CarDetailDto>> GetRentedCarDetails();
        IDataResult<List<CarDetailDto>> GetCarDetailsByBrandId(int id);
        IDataResult<List<CarDetailDto>> GetCarDetailsByColorId(int id);
        IDataResult<List<CarDetailDto>> GetCarDetailsByCarId(int id);
        IDataResult<List<CarDetailDto>> GetCarsByBrandAndColorId(int brandId, int colorId);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IResult AddTransactionalTest(Car car);

    }
}
