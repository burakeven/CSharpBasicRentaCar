using Core.Utilites.Result;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetById(int id);
        IDataResult<List<Car>> GetAll();

        IDataResult<List<Car>> GetCarsByBrandId(int id1);
        IDataResult<List<Car>> GetCarsByColorId(int id2);
        IDataResult<List<CarDetailDto>> GetCarDetails();

        IResult Add(Car car);
    }
}
