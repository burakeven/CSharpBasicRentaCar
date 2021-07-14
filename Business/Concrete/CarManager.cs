using Business.Abstract;
using Business.Constant;
using Core.Utilites.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.Description.Length<2)
            {
                return new ErrorResult(Messages.InvalidCarDescription); //----
            }
            else
            {
                _carDal.Add(car);
                Console.WriteLine("----"+Messages.CarAdded+"----");
                return new SuccessResult(Messages.CarAdded);
            }
            
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
        }

        public IDataResult<List<Car>> GetById(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.Id == id));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id1)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == id1));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id2)
        {
            return new  SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == id2));
        }
    }
}
