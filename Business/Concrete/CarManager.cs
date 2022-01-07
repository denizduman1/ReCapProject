using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
           _carDal = carDal;
        }

        public void Add(Car car)
        {
            //business rules
            bool control = car.Name.Length >= 2
                && car.DailyPrice > 0;

            if (control)
            {
                _carDal.Add(car);
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public Car Get(int id)
        {
            return _carDal.Get(c => c.Id == id);
        }

        public List<Car> GetAll()
        {
           return _carDal.GetAll();
        }

        public List<CarDetailDto> GetAllCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c=>c.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c=>c.ColorId == colorId); 
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
