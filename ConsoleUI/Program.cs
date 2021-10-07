using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>()
            {
                new Car(){Id=1,BrandId=1,ColorId=1,ModelYear=2021,DailyPrice=1100,Description="YENI KASA 3.20i" },
                new Car(){Id=2,BrandId=2,ColorId=2,ModelYear=2020,DailyPrice=2000,Description="Kiralık 2020 Q7" },
                new Car(){Id=3,BrandId=3,ColorId=3,ModelYear=2019,DailyPrice=275,Description="KASKOLU KİRALIK COROLLA DİZEL OTAMATİK VİTES" },
                new Car(){Id=4,BrandId=4,ColorId=2,ModelYear=2019,DailyPrice=400,Description="2019 DİZEL OTOMATİK OPEL İNSİGNİA" }
            };
            
            EfCarDal efcardal = new EfCarDal();
            CarManager carManager = new CarManager( efcardal);
            foreach (var car in cars)
            {
                //efcardal.Add(car);
                carManager.Add(car);               
            }

            //foreach (var car in carManager.GetAll())
            //{           
            //    Console.WriteLine("Gunluk fiyat: "+car.DailyPrice);
            //    Console.WriteLine(car.Description+"\n");
            //}
            
        }
    }
}
