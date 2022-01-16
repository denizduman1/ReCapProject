using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result,IDataResult<T>
    {
        public T Data { get; }
        public DataResult(bool IsSuccess,string Message, T Data) : base(IsSuccess,Message)
        {
            this.Data = Data;
        }
        public DataResult(bool IsSuccess,T Data) : base(IsSuccess)
        {
            this.Data = Data;
        }
    }
}
