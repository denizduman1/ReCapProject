using Core.Entities.File;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CarImageAddDto : IFile
    {
        public int CarId { get; set; }
        public string ImagePath { get ; set ; }
        public IFormFile ImageFile { get; set; }
    }
}
