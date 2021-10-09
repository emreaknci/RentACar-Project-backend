using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
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
                new Car(){Id=4,BrandId=4,ColorId=4,ModelYear=2019,DailyPrice=400,Description="2019 DİZEL OTOMATİK OPEL İNSİGNİA" }
            };
            Car car1 = new Car() { Id = 5, BrandId = 5, ColorId = 5, ModelYear = 2010, DailyPrice = 225, Description = "2010 HONDA CİVİC HASTASİNA KİRALIK" };
            
            List<Brand> brands = new List<Brand>()
            {
                new Brand(){Id=1,Name="BMW"},
                new Brand(){Id=2,Name="AUDI"},
                new Brand(){Id=3,Name="TOYOTA"},
                new Brand(){Id=4,Name="OPEL"},

            };
            Brand brand1 = new Brand() { Id = 5, Name = "HONDA" };

            List<Color> colors = new List<Color>()
            {
                new Color(){Id=1,Name="Kırmızı"},
                new Color(){Id=2,Name="Siyah"},
                new Color(){Id=3,Name="Beyaz"},
                new Color(){Id=4,Name="Gri"},
            };
            Color color1 = new Color() { Id = 5, Name = "Mavi" };

            //CarTest(cars);
            //BrandTest(brands);
            //ColorTest(colors);
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.BrandName+"\n"+car.ColorName + "\n" +car.CarDescription + "\n" +car.DailyPrice + "\n" +car.ModelYear + "\n" );
            }
            
        }

        private static void ColorTest(List<Color> colors)
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colors)
            {
                colorManager.Add(color);
            }
        }

        private static void BrandTest(List<Brand> brands)
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brands)
            {
                brandManager.Add(brand);
            }
        }

        private static void CarTest(List<Car> cars)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in cars)
                carManager.Add(car);
        }
    }
}
