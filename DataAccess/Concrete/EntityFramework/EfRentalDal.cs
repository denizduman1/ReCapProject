using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RecapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (RecapContext context = new RecapContext())
            {
                var result = from r in filter == null ? context.Rentals : context.Rentals.Where(filter)
                             join cus in context.Customers
                             on r.CustomerId equals cus.UserId
                             join u in context.Users
                             on cus.UserId equals u.Id
                             join c in context.Cars
                             on r.CarId equals c.Id                             
                             select new RentalDetailDto
                             {
                                 Id = r.Id,
                                 CarName = c.Name,
                                 CustomerFirstName = u.FirstName,
                                 CustomerLastName = u.LastName,
                                 RentDate = r.RentDate,
                                 ReturnDate = (DateTime)r.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
