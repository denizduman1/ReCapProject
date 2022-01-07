using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car {Id=1,BrandId=1,ColorId=1,DailyPrice=450.50m,Description="uygun fiyatlı aile arabası",ModelYear=new DateTime(2015,1,1)},
                new Car {Id=2,BrandId=5,ColorId=1,DailyPrice=250.99m,Description="uygun fiyatlı iki kişilik araba",ModelYear=new DateTime(2008,1,1)},
                new Car {Id=3,BrandId=3,ColorId=3,DailyPrice=300.00m,Description="uygun fiyatlı aile arabası",ModelYear=new DateTime(2012,1,1)},
                new Car {Id=4,BrandId=2,ColorId=2,DailyPrice=750.30m,Description="lüks aile arabası",ModelYear=new DateTime(2020,1,1)},
                new Car {Id=5,BrandId=4,ColorId=1,DailyPrice=1000.85m,Description="spor araba",ModelYear=new DateTime(2021,1,1)}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car deletedToCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(deletedToCar);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            //return _cars.SingleOrDefault(filter);
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            //return filter == null ? _cars.ToList() : _cars.Where(filter).to 
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car updatedToCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            updatedToCar.BrandId = car.BrandId;
            updatedToCar.ModelYear = car.ModelYear;
            updatedToCar.Description = car.Description;
            updatedToCar.ModelYear = car.ModelYear;
            updatedToCar.DailyPrice = car.DailyPrice;
        }
    }
}
