
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public bool IsSuccess { get; }
        public string Message { get; }
     
        public Result(bool IsSuccess, string Message) : this(IsSuccess)
        {
            this.Message = Message;
        }
        public Result(bool IsSuccess)
        {
            this.IsSuccess = IsSuccess;
        }
    }
}
