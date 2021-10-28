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

            List<User> users = new List<User>()
            {
                new User(){Id=1,FirstName="Yunus Emre",LastName="Akıncı",Email="emreaknci@gmail.com",Password="12345"},
                new User(){Id=2,FirstName="Engin ",LastName="Demirog",Email="engindemirog@gmail.com",Password="159357"},
                new User(){Id=3,FirstName="Ali",LastName="Atay",Email="aliatay@gmail.com",Password="163435"},
                new User(){Id=4,FirstName="Polat",LastName="Alemdar",Email="efekarahanli@gmail.com",Password="alicandan"},
                new User(){Id=5,FirstName="Mustafa Kemal",LastName="Akıncı",Email="mustafaaknci58@gmail.com",Password="58sivas58"}
            };
            User user1 = new User() { Id = 5, FirstName = "Mustafa Kemal", LastName = "Akıncı", Email = "mustafaaknci58@gmail.com", Password = "58sivas58" };

            List<Customer> customers = new List<Customer>()
            {
                new Customer(){UserId=1,CompanyName="Akinci A.Ş."},
                new Customer(){UserId=2,CompanyName="Demirog Software"},
                new Customer(){UserId=3,CompanyName="Ali Atay (Bireysel)"},
            };

            List<Rental> rentals = new List<Rental>()
            {
                new Rental(){Id=1,CarId=4,CustomerId=1,RentDate=new DateTime(2021,10,16)}
            };

            //RentTest(rentals);
            //CutomerTest(customers);
            //UserTest(users);
            //CarTest(cars);
            //BrandTest(brands);
            //ColorTest(colors);

            #region CarDetail
            //CarManager carManager = new CarManager(new EfCarDal());
            //var result = carManager.GetCarDetails();
            //if (result.Success == true)
            //{
            //    foreach (var car in result.Data)
            //    {
            //        Console.WriteLine(car.BrandName + "\n" + car.ColorName + "\n" + car.CarDescription + "\n" + car.DailyPrice + "\n" + car.ModelYear + "\n");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}
            #endregion
            #region UserListed
            //UserManager userManager = new UserManager(new EfUserDal());
            //var result1 = userManager.GetAll();
            //if (result1.Success == true)
            //{
            //    foreach (var user in result1.Data)
            //    {
            //        Console.WriteLine(user.Id + "\n" + user.FirstName + " " + user.LastName + "\n" + user.Email + "\n");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result1.Message);
            //}
            #endregion
        }

        private static void RentTest(List<Rental> rentals)
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            foreach (var rent in rentals)
            {
                rentalManager.Add(rent);
            }
        }

        private static void CutomerTest(List<Customer> customers)
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            foreach (var customer in customers)
            {
                customerManager.Add(customer);
            }
        }

        private static void UserTest(List<User> users)
        {
            UserManager userManager = new UserManager(new EfUserDal());
            
            foreach (var user in users)
            {
                userManager.Add(user);
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
