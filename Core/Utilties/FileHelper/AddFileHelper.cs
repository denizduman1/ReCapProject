using Core.Entities.File;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilties.FileHelper
{
    public static class AddFileHelper
    {
        public static IResult ImageAddFolder(IFile entity, string rootPath)
        {
            var fullPath = Path.Combine($"{rootPath}/{entity.ImagePath}");

            if ((!Directory.Exists(fullPath)))
            {
                Directory.CreateDirectory(fullPath);
            }

            string fileGuid = Guid.NewGuid().ToString();

            string fileExtension = Path.GetExtension(entity.ImageFile.FileName);

            string fileName = fileGuid + fileExtension;

            using (var fileStream = new FileStream(Path.Combine(fullPath, fileName), FileMode.Create))
            {
                entity.ImageFile.CopyTo(fileStream);
            }

            entity.ImagePath = entity.ImagePath + "/" + fileName;

            return new SuccessResult();
        }

    }
}
