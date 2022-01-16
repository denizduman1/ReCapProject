using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>, IDataResult<T>
    {
        public ErrorDataResult(string Message, T Data) : base(false, Message, Data)
        {

        }
        public ErrorDataResult(T Data) : base(false, Data)
        {

        }
        public ErrorDataResult(string Message) : base(false, Message, default)
        {

        }
        public ErrorDataResult() : base(false, default)
        {

        }
    }
}
