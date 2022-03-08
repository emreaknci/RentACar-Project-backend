using Core.Utilities.Results;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int Id);

        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);

        User GetByMail(string email);
        List<OperationClaim> GetClaims(User user);
    }
}
