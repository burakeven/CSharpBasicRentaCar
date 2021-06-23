using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=1, DailyPrice=55000, ModelYear=1999,Description="1999 Model Toyota Corolla"},
                new Car{Id=1, BrandId=1, ColorId=1, DailyPrice=125000, ModelYear=2012,Description="2012 Model Yeni Kasa Toyota Corolla"},
                new Car{Id=3, BrandId=2, ColorId=0, DailyPrice=133000, ModelYear=2015,Description="2015 Model Hyundai Accent Blue"},
                new Car{Id=4, BrandId=2, ColorId=0, DailyPrice=95000, ModelYear=2009,Description="2009 Model Fiat Punto Evo 1.3 Multijet"},
                new Car{Id=5, BrandId=3, ColorId=1, DailyPrice=275000, ModelYear=2013,Description="2013 Model 3.20d BMW M Sport"},
                new Car{Id=6, BrandId=3, ColorId=1, DailyPrice=45000, ModelYear=1996,Description="1996 Model Şahin"}
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById()
        {
            return _car;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
