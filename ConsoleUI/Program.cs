using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();

        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //EfCarDal efCarDal = new EfCarDal();
            //efCarDal.Add(new Car
            //{
            //    Id = 8,
            //    BrandId = 3,
            //    ColorId = 0,
            //    DailyPrice = 1000,
            //    ModelYear = 1992,
            //    Description = "1992 Model Araba"
            //});
            //efCarDal.Add(new Car { Id = 8, BrandId = 3, ColorId = 0, DailyPrice = 1000, ModelYear = 1992, Description = "1992 Model Araba" });
            //EfCarDal efCarDal = new EfCarDal();
            //efCarDal.Add(new Car { Id = 10, BrandId = 3, ColorId = 0, DailyPrice = 250, ModelYear = 1995, Description = "1995 Model Opel" });
            foreach (var item in carManager.GetCarDetails())
            {
                Console.WriteLine(item.Id+ " " + item.BrandId + " " + item.ColorId + " " + item.DailyPrice + " " + item.Description);
            }
        }
    }
}
