// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;


CarManager carManager = new CarManager(new EfCarDal());
List<Car> cars = carManager.GetAll();


foreach (var car in cars)
{
    Console.WriteLine(car.Id + " " + car.BrandId + " " + car.Name + " " + car.ColorId + " " + car.DailyPrice + " " 
        + car.ModelYear.Year + " " + car.Description);
    Console.WriteLine("---");
}
