using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.File
{
    public interface IFile
    {
        string ImagePath { get; set; }
        IFormFile ImageFile { get; set; }
    }
}
