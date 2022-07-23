using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarDbContext>, IRentalDal
    {
        public List<RentalDetailsDto> GetRentalDetails(Expression<Func<RentalDetailsDto, bool>> filter = null)
        {
            using (RentACarDbContext context = new RentACarDbContext())
            {
                var result = from re in context.Rentals
                             join ca in context.Cars 
                             on re.CarId equals ca.Id
                             join br in context.Brands
                             on ca.BrandId equals br.Id
                             join cu in context.Customers
                             on re.CustomerId equals cu.UserId
                             join u in context.Users
                             on cu.UserId equals u.Id

                             select new RentalDetailsDto()
                             {
                                 Id = re.Id,
                                 BrandName = br.Name,
                                 CustomerName = u.FirstName+" "+u.LastName,
                                 RentDate = re.RentDate,
                                 ReturnDate = re.ReturnDate
                             };
                return filter == null
                    ? result.ToList()
                    : result.Where(filter).ToList();
            }
        }
    }
}
