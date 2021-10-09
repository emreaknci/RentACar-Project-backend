using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine(car.Id + " Id'li araba bilgileri basariyla eklendi!" +
                   "\nRenk Id: " + car.ColorId +
                   "\nModel Yili: " + car.ModelYear +
                   "\nGunluk Ucret: " + car.DailyPrice +
                   "\nAciklama: " + car.Description + "\n\n");
            }
            else if (car.Description.Length < 2 && car.DailyPrice > 0)
                Console.WriteLine("Araba adi en az 2 harfli olmalıdır!");
            else if (car.Description.Length >= 2 && car.DailyPrice <= 0)
                Console.WriteLine("Kiralama bedeli 0 veya o'dan kucuk olamaz!");
            else
                Console.WriteLine("Araba ismi en az iki harfli , gunluk kiralama bedeli 0'dan buyuk olmalidir!");
        }
        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine(car.Id + " Id'li araba bilgileri silindi!"+                  
                   "\nRenk Id: " + car.ColorId +
                   "\nModel Yili: " + car.ModelYear +
                   "\nGunluk Ucret: " + car.DailyPrice +
                   "\nAciklama: " + car.Description + "\n\n");
        }
        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine(car.Id + " Id'li araba bilgileri guncellendi!");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
        public List<Car> GetCarsByBrandId(int Id)
        {
            return _carDal.GetAll(c => c.BrandId == Id);
        }
        public List<Car> GetCarsByColorId(int Id)
        {
            return _carDal.GetAll(c => c.ColorId == Id);
        }
        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }     
    }
}
