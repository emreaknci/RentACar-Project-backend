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
    public class EfCustomerDal: EfEntityRepositoryBase<Customer, RentACarDbContext>, ICustomerDal
    {
        public CustomerDetailDto GetCustomersWithDetail(string email)
        {
            using RentACarDbContext context = new RentACarDbContext();
            var result = from u in context.Users
                join c in context.Customers
                    on u.Id equals c.UserId

                select new CustomerDetailDto()
                {
                   Id = c.UserId,
                   CompanyName = c.CompanyName,
                   CreditCards = (from cd in context.CreditCards where (cd.CustomerId == c.UserId) select cd).ToList(),
                   Email = u.Email,
                   FirstName = u.FirstName,
                   LastName = u.LastName
                };
            return result.FirstOrDefault(p => p.Email==email);
        }
    }
}
