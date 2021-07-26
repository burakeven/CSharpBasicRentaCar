using Core.Utilites.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<Customer> GetById(int id);
        IDataResult<List<Customer>> GetAll();
        //IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult Add(Customer user);
        IResult Delete(Customer user);
        IResult Update(Customer user);
    }
}
