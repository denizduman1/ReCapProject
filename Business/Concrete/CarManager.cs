using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(Car car)
        {
            //business rules
            bool control = car.Name.Length >= 2
                && car.DailyPrice > 0;

            if (control)
            {
                 _carDal.Add(car);
                return new SuccessResult(Messages.CarAdded);
            }
            return new ErrorResult(Messages.CarCantAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<Car> Get(int id)
        {
            var car = _carDal.Get(c => c.Id == id);
            return new SuccessDataResult<Car>(Messages.GetCar,car);
        }

        public IDataResult<List<Car>> GetAll()
        {
             List<Car> cars = _carDal.GetAll();
             return new SuccessDataResult<List<Car>>(Messages.GetCars, cars);
        }

        public IDataResult<List<CarDetailDto>> GetAllCarDetails()
        {
            List<CarDetailDto> carDetailDtos = _carDal.GetCarDetails();
            return new SuccessDataResult<List<CarDetailDto>>(Messages.GetCars,carDetailDtos);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            List<Car> carsbyBrandId = _carDal.GetAll(c=>c.BrandId == brandId);
            return new SuccessDataResult<List<Car>>(Messages.GetCars, carsbyBrandId);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            List<Car> carsbyColorId = _carDal.GetAll(c=>c.ColorId == colorId);
            return new SuccessDataResult<List<Car>>(Messages.GetCars,carsbyColorId);
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
