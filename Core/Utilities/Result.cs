using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class Result : IResult
    {
        public Result(bool succes,string message) 
        {
            Message = message;
            Success = succes;
        }
        public Result(bool success)
        {
            Success = success;
        }
        
        public bool Success { get; }
        public string Message { get; }
    }
}
