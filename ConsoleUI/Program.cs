using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            var cars = carManager.GetAll();
            foreach (var car in cars)
            {
                Console.WriteLine(car.Id+ " " +car.DailyPrice+ " "+car.Description);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
