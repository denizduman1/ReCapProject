using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(CarImageAddDto carImageAddDto, string path);
        IResult Update(CarImageUpdateDto carImageUpdateDto, string path);
        IResult Delete(CarImageDeleteDto carImageDeleteDto, string path);
        IDataResult<CarImage> Get(int id);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetbyCarId(int carId);
    }
}
