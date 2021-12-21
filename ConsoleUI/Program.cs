// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;


CarManager carManager = new CarManager(new InMemoryCarDal());
List<Car> cars = carManager.GetAll();

foreach (var car in cars)
{
    Console.WriteLine(car.Id + " " + car.BrandId + " " + car.ColorId + " " + car.DailyPrice + " " + car.ModelYear.Year + " " + car.Description);
    Console.WriteLine("---");
}
