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
            //CarTest();
            //UserTest();
            //CustomerTest();
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Rental rental1 = new Rental();
            rental1.Id = 1;
            rental1.CarId = 1;
            rental1.CustomerId = 1;
            rental1.RentDate = new DateTime(2021, 1, 1);
            rental1.ReturnDate = new DateTime(2021, 1, 18);

            var result = rentalManager.Add(rental1);

            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer { UserId = 1, CompanyName = "Even LLC" });
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User { Id = 1, FirstName = "Burak", LastName = "Even", Email = "burak.even@hotmail.com", Password = "112233" });
            userManager.Add(new User { Id = 2, FirstName = "Ahmet", LastName = "Even", Email = "ahmet.even@hotmail.com", Password = "567890" });
            userManager.Add(new User { Id = 3, FirstName = "Irem", LastName = "Even", Email = "irem.even@hotmail.com", Password = "123456" });
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { Id = 16, BrandId = 2, ColorId = 0, ModelYear = 2015, DailyPrice = 499, Description = "Test4 for Add on Messages" });
          
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
