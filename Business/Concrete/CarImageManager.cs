using AutoMapper;
using Business.Abstract;
using Core.Entities.File;
using Core.Utilities.Results;
using Core.Utilties.Business;
using Core.Utilties.FileHelper;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        IMapper _mapper;

        public CarImageManager(ICarImageDal carImageDal, IMapper mapper)
        {
            _carImageDal = carImageDal;
            _mapper = mapper;
        }

        public IResult Add(CarImageAddDto carImageAddDto, string path)
        {
            var res = BusinessEngine.Run(AddFileHelper.ImageAddFolder(carImageAddDto, path),
                ImageAddMaxCount(carImageAddDto.CarId));
            if (res.IsSuccess)
            {
                var carImage = _mapper.Map<CarImage>(carImageAddDto);
                _carImageDal.Add(carImage);
                return new SuccessResult();
            }
            return res;
        }

        private IResult ImageAddMaxCount(int carId)
        {
            var res = _carImageDal.GetAll(c => c.CarId == carId).Count;
            if (res < 5)
            {
                return new SuccessResult();
            }
            return new ErrorResult("Bir arabanın max 5 resmi olabilir");
        }

        public IResult Delete(CarImageDeleteDto carImageDeleteDto, string path)
        {
            var fullPath = Path.Combine($"{path}/{carImageDeleteDto.ImagePath}");
            var res = RemoveFileHelper.ImageDeleteFromFolder(fullPath);
            if (res.IsSuccess)
            {
                CarImage carImage = _carImageDal.GetAll(c => c.ImagePath == carImageDeleteDto.ImagePath)
                    .FirstOrDefault();

                if (carImage != null)
                {
                    _carImageDal.Delete(carImage);
                    return new SuccessDataResult<CarImage>("Başarılı silme", carImage);
                }
                else
                {
                    return new ErrorDataResult<CarImage>("Veritabanında ilgili resim kaydı bulunamadı", carImage);
                }
            }
            return new ErrorResult(res.Message);
        }

        public IDataResult<CarImage> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            var res = _carImageDal.GetAll();
            if (res.Count > 0)
            {
                return new SuccessDataResult<List<CarImage>>(res);
            }
            return new ErrorDataResult<List<CarImage>>("resim yok", res);
        }

        public IResult Update(CarImageUpdateDto carImageUpdateDto, string path)
        {
            var res = BusinessEngine.Run(AddFileHelper.ImageAddFolder(carImageUpdateDto, path),
               ImageAddMaxCount(carImageUpdateDto.CarId));
            if (res.IsSuccess)
            {
                //eskisini sileceğiz.
                var oldcarImage = _carImageDal.Get(c => c.Id == carImageUpdateDto.Id);
                var fullPath = Path.Combine($"{path}/{oldcarImage.ImagePath}");

                var resDelete = RemoveFileHelper.ImageDeleteFromFolder(fullPath);
                if (resDelete.IsSuccess)
                {
                    var carImage = _mapper.Map<CarImage>(carImageUpdateDto);
                    _carImageDal.Update(carImage);
                    return new SuccessResult();
                }
                return new ErrorResult("Resim Eklendi fakat silinecek resim bulunamadı");
            }
            return res;
        }

        public IDataResult<List<CarImage>> GetbyCarId(int carId)
        {
            var res = ExistImageForCar(carId);
            if (res.IsSuccess)
            {
                return new SuccessDataResult<List<CarImage>>("Resimler başarıyla getirildi", res.Data);
            }
            return new SuccessDataResult<List<CarImage>>("Default resim getirildi", new List<CarImage>
            {
                new CarImage
                {
                    ImagePath = "/img/sirketLogo.jpg"
                }
            });
        }
        private IDataResult<List<CarImage>> ExistImageForCar(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId);
            if (result.Count > 0)
            {
                return new SuccessDataResult<List<CarImage>>(result);
            }
            return new ErrorDataResult<List<CarImage>>();
        }
    }
}
