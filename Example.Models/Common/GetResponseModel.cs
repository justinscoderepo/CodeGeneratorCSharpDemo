using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Models.Common
{
    public class GetResponseModel<T>
    {
        public int TotalItems { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public int StartPage { get; set; }
        public int EndPage { get; set; }
        public int StartIndex { get; set; }
        public int EndIndex { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
        public List<int> Pages { get; set; }
        public List<T> Data { get; set; }
    }
}
