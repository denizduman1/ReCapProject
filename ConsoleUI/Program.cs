// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;

CarManager carManager = new(new EfCarDal());
List<Car> cars = carManager.GetAll();


foreach (var car in cars)
{
    Console.WriteLine(car.Id + " " + car.BrandId + " " + car.Name + " " + car.ColorId + " " + car.DailyPrice + " " 
        + car.ModelYear.Year + " " + car.Description);
    Console.WriteLine("---");
}


List<CarDetailDto> carsDetails = carManager.GetAllCarDetails();


foreach (var car in carsDetails)
{
    Console.WriteLine(car.CarId + " " + car.CarName + " " + car.BrandName + " " + car.ColorName + " " + car.DailyPrice);
    Console.WriteLine("---");
}

