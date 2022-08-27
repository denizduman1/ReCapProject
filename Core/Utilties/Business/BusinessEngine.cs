using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilties.Business
{
    public static class BusinessEngine
    {
        public static IResult Run(params IResult[] methods)
        {
            foreach (var method in methods)
            {
                if (!method.IsSuccess)
                {
                    return method;
                }
            }
            return methods.LastOrDefault() ?? null;
        } 
    }
}
