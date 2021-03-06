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
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            CarImageManager carImageManager = new CarImageManager(new EfCarImageDal());
            //var result = carImageManager.GetAll();
            //foreach (var res in result.Data)
            //{
            //    Console.WriteLine(res.Id+" "+res.CarId+" "+res.ImagePath+" "+res.Date);
            //}
            //BrandList(brandManager);
            //Console.WriteLine(Guid.NewGuid());
        }

        private static void RentalDetailList(RentalManager rentalManager)
        {
            var result = rentalManager.GetRentalDetails();
            foreach (var rentalDetail in result.Data)
            {
                Console.WriteLine(rentalDetail.Id + " " + rentalDetail.CarName + " " + rentalDetail.CustomerFirstName + " " + rentalDetail.CustomerLastName + " " + rentalDetail.RentDate + " " + rentalDetail.ReturnDate);
            }
        }

        private static void CustomerDetailList(CustomerManager customerManager)
        {
            var result = customerManager.GetCustomerDetails();
            foreach (var customer in result.Data)
            {
                Console.WriteLine(customer.UserId + " " + customer.FirstName + " " + customer.LastName + " " + customer.CompanyName);
            }
        }

        private static void CustomerList(CustomerManager customerManager)
        {
            var result = customerManager.GetAll();
            foreach (var customer in result.Data)
            {
                Console.WriteLine(customer.UserId + " " + customer.CompanyName);
            }
        }

        private static void UserList(UserManager userManager)
        {
            var result = userManager.GetAll();
            foreach (var user in result.Data)
            {
                Console.WriteLine(user.Id + " " + user.FirstName + " " + user.LastName);
            }
        }

        private static void AddNewData(CarManager carManager, ColorManager colorManager, BrandManager brandManager)
        {
            colorManager.Add(new Color { Id = 3, Name = "Beyaz" });
            brandManager.Add(new Brand { Id = 3, Name = "Toyota" });
            carManager.Add(new Car { Id = 3, Name = "Toyota Yaris", BrandId = 3, DailyPrice = 189000, ColorId = 3, ModelYear = 2018, Description = "bir japon harikası" });
        }

        private static void CarDetailList(CarManager carManager)
        {
            var result = carManager.GetCarDetails();
           
            foreach (var cars in result.Data)
            {
                Console.WriteLine(cars.Id + " " + cars.Brand + " (" + cars.Name + ") " + cars.Color +" "+cars.DailyPrice + "$");
            }
        }

        private static void BrandList(BrandManager brandManager)
        {
            var result = brandManager.GetAll();
            foreach (var brand in result.Data)
            {
                Console.WriteLine(brand.Id + " " + brand.Name);
            }
            Console.WriteLine(result.Message);
        }

        private static void ColorList(ColorManager colorManager)
        {
            var result = colorManager.GetAll();
            foreach (var color in result.Data)
            {
                Console.WriteLine(color.Id + " " + color.Name);
            }
            Console.WriteLine(result.Message);
        }

        private static void CarList(CarManager carManager)
        {
            var result = carManager.GetAll();
            if (result.Success==true)
            {
                foreach (var cars in result.Data)
                {
                    Console.WriteLine(cars.Id + " " + cars.BrandId + " " + cars.ColorId + " " + cars.Name + " " + cars.ModelYear + " " + cars.DailyPrice + "$");   
                }
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }           
        }
    }
}
