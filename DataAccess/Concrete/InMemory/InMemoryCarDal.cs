using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        //List<Car> _cars;

        //public InMemoryCarDal()
        //{
        //    _cars = new List<Car>
        //    {
        //        new Car{Id=1,BrandId=1,ColorId=4,ModelYear=2006,DailyPrice=52000,Description="Temiz kullanılmış araba."},
        //        new Car{Id=2,BrandId=2,ColorId=3,ModelYear=2016,DailyPrice=93000,Description="Benzini az tüketen araba."},
        //        new Car{Id=3,BrandId=3,ColorId=2,ModelYear=2020,DailyPrice=140000,Description="Hızlı araba."},
        //        new Car{Id=4,BrandId=4,ColorId=1,ModelYear=2009,DailyPrice=71000,Description="Fazla yıpranmamış araba."},
        //    };
        //}

        //public void Add(Car car)
        //{
        //    _cars.Add(car);
        //}

        //public void Delete(Car car)
        //{
        //    Car deletedCar = _cars.SingleOrDefault(c => c.Id == car.Id);
        //    _cars.Remove(deletedCar);
        //}

        //public List<Car> GetAll()
        //{
        //    return _cars;
        //}

        //public Car GetById(int id)
        //{
        //    Car car;
        //    car = _cars.SingleOrDefault(c => c.Id == id);
        //    return car;
        //}

        //public void Update(Car car)
        //{
        //    Car updatedCar = _cars.SingleOrDefault(c => c.Id == car.Id);
        //    updatedCar.ModelYear = car.ModelYear;
        //    updatedCar.DailyPrice = car.DailyPrice;
        //    updatedCar.ColorId = car.ColorId;
        //    updatedCar.Description = car.Description;
        //    updatedCar.BrandId = car.BrandId;
        //}
        public void Add(Car entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
