using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example.WebApi.Controllers.Utilities
{
    public abstract class BaseURLService
    {
        private IHttpContextAccessor _httpContextAccessor;

        protected BaseURLService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public string GetBaseUrl()
        {
            var authority = _httpContextAccessor.HttpContext.Request.IsHttps ? "https://" : "http://";
            var host = GetHost();
            return $"{authority}{host}";
        }
        private string GetHost()
        {
            return _httpContextAccessor.HttpContext.Request.Host.Value;
        }
    }
}
