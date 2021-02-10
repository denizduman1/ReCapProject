using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Entities.Concrete.Car {Id=1,BrandId=1,ColorId=1,Name="Hyundai",DailyPrice=75000,ModelYear=2011,Description="ter temiz araç" });
            carManager.Add(new Entities.Concrete.Car { Id = 1, BrandId = 1, ColorId = 1, Name = "H", DailyPrice = 75000, ModelYear = 2011, Description = "ter temiz araç" });
            var cars = carManager.GetAll();
            foreach (var car in cars)
            {
                Console.WriteLine(car.Id+ " " +car.DailyPrice+ " "+car.Description);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
