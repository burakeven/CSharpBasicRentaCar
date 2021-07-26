using Core.Utilites.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<User> GetById(int id);
        IDataResult<List<User>> GetAll();
        //IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult Add(User customer);
        IResult Delete(User customer);
        IResult Update(User customer);
    }
}
