using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Models.Common
{
    public class RawResponseModel<T>
    {
        public RawResponseModel(T Data, string message = "", bool success = true)
        {
            this.Data = Data;
            this.Message = message;
            this.Success = success;
        }
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}
