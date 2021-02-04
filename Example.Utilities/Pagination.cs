using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Example.Models.Common;

namespace Example.Utilities
{
    public class Pagination<T> : GetResponseModel<T>
    {
        public Pagination(
                   int currentPage = 1,
                   int pageSize = 20)
        {
            if (currentPage < 1)
            {
                currentPage = 1;
            }
            var startIndex = (currentPage - 1) * pageSize;
            this.StartIndex = startIndex;
            this.CurrentPage = currentPage;
            this.PageSize = pageSize;
        }
        public void results(IEnumerable<T> results)
        {
            var totalItems = 0;
            try
            {
                totalItems = results.Count();

                
                results = results.Skip(this.StartIndex).Take(this.PageSize);
                this.Data = results.ToList();
            }
            catch (Exception ex)
            {
                this.Data = null;
                this.Success = false;
                totalItems = 0;
            }

            this.TotalPages = (int)Math.Ceiling((decimal)totalItems / (decimal)this.PageSize);
            // ensure current page isn't out of range
            if (this.CurrentPage > this.TotalPages)
            {
                this.CurrentPage = this.TotalPages;
            }

            int startPage = 1, endPage = 1;
            if (this.TotalPages <= this.PageSize)
            {
                // total pages less than max so show all pages
                startPage = 1;
                endPage = this.TotalPages;
            }
            var endIndex = Math.Min(this.StartIndex + this.PageSize - 1, totalItems - 1);

            this.TotalItems = totalItems;
            this.StartPage = startPage;
            this.EndPage = endPage;
            this.EndIndex = endIndex;
        }

    }
}


