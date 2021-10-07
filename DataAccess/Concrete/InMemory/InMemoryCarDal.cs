using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car(){Id=1,BrandId=1,ColorId=1,ModelYear=2021,DailyPrice=1100,Description="YENI KASA 3.20i" },
                new Car(){Id=2,BrandId=2,ColorId=2,ModelYear=2020,DailyPrice=2000,Description="Kiralık 2020 Q7" },
                new Car(){Id=3,BrandId=3,ColorId=3,ModelYear=2019,DailyPrice=275,Description="KASKOLU KİRALIK COROLLA DİZEL OTAMATİK VİTES" },
                new Car(){Id=4,BrandId=4,ColorId=2,ModelYear=2019,DailyPrice=400,Description="2019 DİZEL OTOMATİK OPEL İNSİGNİA" }

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            _cars.Where(c => c.Id == Id).ToList();
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
