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
            carManager.Add(new Car { Id = 16, BrandId = 2, ColorId = 0, ModelYear = 2015, DailyPrice = 499, Description = "Test4 for Add on Messages" });
            
            //EfCarDal efCarDal = new EfCarDal();
            //efCarDal.Add(new Car
            //{
            //    Id = 11,
            //    BrandId = 2,
            //    ColorId = 0,
            //    ModelYear = 1989,
            //    DailyPrice = 150,
            //    Description = "1989 Model Murat 131"
            //});
            //efCarDal.Add(new Car { Id = 8, BrandId = 3, ColorId = 0, DailyPrice = 1000, ModelYear = 1992, Description = "1992 Model Araba" });
            //EfCarDal efCarDal = new EfCarDal();
            //efCarDal.Add(new Car { Id = 10, BrandId = 3, ColorId = 0, DailyPrice = 250, ModelYear = 1995, Description = "1995 Model Opel" });
            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.Id + " " + item.BrandId + " " + item.ColorId + " " + item.DailyPrice + " " + item.Description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
