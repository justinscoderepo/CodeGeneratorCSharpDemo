using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Models.Common
{
    public class DeleteResponseModel
    {
        public DeleteResponseModel(string message = "", bool success = true)
        {
            this.Message = message;
            this.Success = success;
        }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
