using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Models.Common
{
    public class FileResponseModel<T>
    {
        public FileResponseModel(T Data, string message = "", bool success = true, string fileSize = "", string fileName = "", int fileType = 0)
        {
            this.Data = Data;
            this.Message = message;
            this.Success = success;
            this.FileSize = fileSize;
            this.FileName = fileName;
            this.FileType = fileType;
        }
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public string FileSize { get; set; }
        public int FileType { get; set; }
        public string FileName { get; set; }
    }
}
