using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetById(int id);
        List<Car> GetAll();

        List<Car> GetCarsByBrandId(int id1);
        List<Car> GetCarsByColorId(int id2);
        List<CarDetailDto> GetCarDetails();
    }
}
