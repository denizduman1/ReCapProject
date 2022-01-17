// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;

//CarManager carManager = new(new EfCarDal());
//List<Car> cars = carManager.GetAll().Data;


//foreach (var car in cars)
//{
//    Console.WriteLine(car.Id + " " + car.BrandId + " " + car.Name + " " + car.ColorId + " " + car.DailyPrice + " " 
//        + car.ModelYear.Year + " " + car.Description);
//    Console.WriteLine("---");
//}


//List<CarDetailDto> carsDetails = carManager.GetAllCarDetails().Data;


//foreach (var car in carsDetails)
//{
//    Console.WriteLine();
//    Console.WriteLine(car.CarId + " " + car.CarName + " " + car.BrandName + " " + car.ColorName + " " + car.DailyPrice);
//    Console.WriteLine("---");
//}

//Console.WriteLine("-------------------");


//Console.WriteLine(carManager.Add(new Car() { Name = "a", DailyPrice = 1 }).Message);

//var carswithResult = carManager.GetAll();

//if (carswithResult.IsSuccess)
//{
//    Console.WriteLine(carswithResult.Message);
//    foreach (var car in carswithResult.Data)
//    {
//        Console.WriteLine(car.Id + " " + car.BrandId + " " + car.Name + " " + car.ColorId + " " + car.DailyPrice + " "
//            + car.ModelYear.Year + " " + car.Description);
//        Console.WriteLine("---");
//    }
//}

//Console.WriteLine("--------------");

//ColorManager colorManager = new ColorManager(new EfColorDal());

//if (colorManager.GetAll().IsSuccess)
//{
//    foreach (var color in colorManager.GetAll().Data)
//    {
//        Console.Write(color.Name + "--");
//    }
//}
//else
//{
//    Console.WriteLine(colorManager.GetAll().Message);
//}

//Console.WriteLine();

//BrandManager brandManager = new BrandManager(new EfBrandDal());

//if (brandManager.GetAll().IsSuccess)
//{
//    foreach (var brand in brandManager.GetAll().Data)
//    {
//        Console.Write(brand.Name + "--");
//    }
//}
//else
//{
//    Console.WriteLine(colorManager.GetAll().Message);
//}


RentalManager rentalManager = new RentalManager(new EfRentalDal());

var rentalAdd = rentalManager.Add(new Rental()
{
   CarId = 1,
   CustomerId = 1
});

if (rentalAdd.IsSuccess)
{
    Console.WriteLine(rentalAdd.Message);
}
else
{
    Console.WriteLine(rentalAdd.Message);
}

var rentals = rentalManager.GetAll();

if (rentals.IsSuccess)
{
    foreach (var rental in rentals.Data)
    {
        Console.WriteLine(rental.Id + " " + rental.CarId + " " + rental.CustomerId + " " +rental.RentDate + " ");
    }
}
else
{
    Console.WriteLine(rentals.Message);
}