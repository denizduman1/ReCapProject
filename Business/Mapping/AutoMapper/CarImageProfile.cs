using AutoMapper;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mapping.AutoMapper
{
    public class CarImageProfile : Profile
    {
        public CarImageProfile()
        {
            CreateMap<CarImageAddDto, CarImage>()
                .ForMember(c=>c.Date, opt=>opt.MapFrom(x=>DateTime.Now));
            CreateMap<CarImageDeleteDto, CarImage>();
            CreateMap<CarImageUpdateDto, CarImage>()
                .ForMember(c=>c.Date, opt=>opt.MapFrom(x=>DateTime.Now));
        }
    }
}
