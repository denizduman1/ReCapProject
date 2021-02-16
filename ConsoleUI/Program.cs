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
            //CarList(carManager);
            ColorManager colorManager = new ColorManager(new EfColorDal());
            //ColorList(colorManager);
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //BrandList(brandManager);
            //CarDetailList(carManager);
            //AddNewData(carManager, colorManager, brandManager);
            CarDetailList(carManager);
        }

        private static void AddNewData(CarManager carManager, ColorManager colorManager, BrandManager brandManager)
        {
            colorManager.Add(new Color { Id = 3, Name = "Beyaz" });
            brandManager.Add(new Brand { Id = 3, Name = "Toyota" });
            carManager.Add(new Car { Id = 3, Name = "Toyota Yaris", BrandId = 3, DailyPrice = 189000, ColorId = 3, ModelYear = 2018, Description = "bir japon harikası" });
        }

        private static void CarDetailList(CarManager carManager)
        {
            foreach (var cars in carManager.GetCarDetails())
            {
                Console.WriteLine(cars.Id + " " + cars.Brand + " (" + cars.Name + ") " + cars.Color +" "+cars.DailyPrice + "$");
            }
        }

        private static void BrandList(BrandManager brandManager)
        {
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Id + " " + brand.Name);
            }
        }

        private static void ColorList(ColorManager colorManager)
        {
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.Id + " " + color.Name);
            }
        }

        private static void CarList(CarManager carManager)
        {
            foreach (var cars in carManager.GetAll())
            {
                Console.WriteLine(cars.Id + " " + cars.BrandId + " " + cars.ColorId + " " + cars.Name + " " + cars.ModelYear + " " + cars.DailyPrice + "$");
            }
        }
    }
}
