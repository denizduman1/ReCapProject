using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilties.FileHelper
{
    public static class RemoveFileHelper
    {
        public static IResult ImageDeleteFromFolder(string fullPath)
        {
            try
            {
                System.IO.File.Delete(fullPath);
            }
            catch (Exception e)
            {
                return new ErrorResult("Dosya silme işleminde hata oluştu. Dosya bulunamamış olabilir");
            }
            return new SuccessResult();

        }

    }
}
