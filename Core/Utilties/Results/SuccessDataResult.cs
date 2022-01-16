using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>,IDataResult<T>
    {
        public SuccessDataResult(string Message, T Data) : base(true, Message, Data)
        {

        }
        public SuccessDataResult(T Data)  : base(true, Data)
        {
                
        }
        public SuccessDataResult(string Message) : base(true, Message, default)
        {

        }
        public SuccessDataResult() : base(true, default)
        {

        }
    }
}
