using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.Data.SqlClient;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarDbContext>, ICarDal
    {

        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            List<string> defaultImages = new List<string>()
            {
                "/Images/default.png",
            };
            using RentACarDbContext context = new RentACarDbContext();
            var result = from c in context.Cars
                join b in context.Brands
                    on c.BrandId equals b.Id
                join co in context.Colors
                    on c.ColorId equals co.Id

                select new CarDetailDto()
                {
                    Id = c.Id,
                    BrandId = b.Id,
                    ColorId = co.Id,
                    BrandName = b.Name,
                    ColorName = co.Name,
                    ModelYear = c.ModelYear,
                    DailyPrice = c.DailyPrice,
                    CarDescription = c.Description,
                    Images = (from i in context.CarImages where (c.Id == i.CarId) select i.ImagePath).ToList().Count!=0
                        ? (from i in context.CarImages where (c.Id == i.CarId) select i.ImagePath).ToList()
                        : defaultImages.ToList()
                };
            return filter == null
                ? result.ToList()
                : result.Where(filter).ToList();
        }

        public List<CarDetailDto> GetRentalableCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            var allCarIdList = new List<int>();
            var rentedCarIdList = new List<int>();

            GetCarDetails().ForEach(c => allCarIdList.Add(c.Id));
            GetRentedCarDetails().ForEach(c => rentedCarIdList.Add(c.Id));
            var rentableCarIdList = allCarIdList.Except(rentedCarIdList).ToList();

            var rentableCarList = new List<CarDetailDto>();
            rentableCarIdList.ForEach(id => rentableCarList.Add(GetCarDetails().Find(c => c.Id == id)));
            return rentableCarList;
        }

        public List<CarDetailDto> GetRentedCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            List<string> defaultImages = new List<string>()
            {
                "/Images/default.png",
            };
            using RentACarDbContext context = new RentACarDbContext();
            var result = from c in context.Cars
                join r in context.Rentals
                    on c.Id equals r.CarId
                join b in context.Brands
                    on c.BrandId equals b.Id
                join co in context.Colors
                    on c.ColorId equals co.Id
                select new CarDetailDto()
                {
                    Id = c.Id,
                    BrandId = b.Id,
                    ColorId = co.Id,
                    BrandName = b.Name,
                    ColorName = co.Name,
                    ModelYear = c.ModelYear,
                    DailyPrice = c.DailyPrice,
                    CarDescription = c.Description,
                    Images = (from i in context.CarImages where (c.Id == i.CarId) select i.ImagePath).ToList().Count != 0
                        ? (from i in context.CarImages where (c.Id == i.CarId) select i.ImagePath).ToList()
                        : defaultImages.ToList()
                };
            return filter == null
                ? result.ToList()
                : result.Where(filter).ToList();
        }
    }
}

