using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace WebAPI.Extensions
{
    public static class ServiceCollectionExtensions 
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection)
        {
            //serviceCollection.AddSingleton<IBrandService, BrandManager>();
            //serviceCollection.AddSingleton<IBrandDal, EfBrandDal>();
            //serviceCollection.AddSingleton<ICarService, CarManager>();
            //serviceCollection.AddSingleton<ICarDal, EfCarDal>();
            //serviceCollection.AddSingleton<IColorService, ColorManager>();
            //serviceCollection.AddSingleton<IColorDal, EfColorDal>();
            //serviceCollection.AddSingleton<IRentalService, RentalManager>();
            //serviceCollection.AddSingleton<IRentalDal, EfRentalDal>();
            //serviceCollection.AddSingleton<ICustomerService, CustomerManager>();
            //serviceCollection.AddSingleton<ICustomerDal, EfCustomerDal>();
            //serviceCollection.AddSingleton<IUserService, UserManager>();
            //serviceCollection.AddSingleton<IUserDal, EfUserDal>();

            return serviceCollection;
        }
    }
}
