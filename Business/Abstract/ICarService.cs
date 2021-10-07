using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByColorId(int Id);
        List<Car> GetCarsByBrandId(int Id);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
