using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {
            var checkCar = _rentalDal.GetAll(r=>r.CarId  == rental.CarId).LastOrDefault();

            if (checkCar!=null)
            {
                if (checkCar.ReturnDate <= DateTime.Now)
                {
                    rental.RentDate = DateTime.Now;
                    _rentalDal.Add(rental);
                    return new SuccessResult("Araba kiralandı.");
                }
                else
                {
                    return new ErrorResult("Araba kiralama için müsait değil.");
                }
            }
            else
            {
                rental.RentDate = DateTime.Now;
                _rentalDal.Add(rental);
                return new SuccessResult("Araba kiralandı.");
            }            
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetbyId(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r=>r.Id == id));
        }
    }
}
