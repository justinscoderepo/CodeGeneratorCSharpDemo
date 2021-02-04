using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example.WebApi.Controllers.Utilities
{
    public static class ImageChecker
    {
        public static bool ImageCheck(string url)
        {
            var imageTypes = new List<string>(new string[] { "png", "jpg", "jpeg" });
            if (imageTypes.Any(x => x == (url.Split('.')[url.Split('.').Length - 1]).ToLower()))
            {
                return true;
            }
            return false;
        }
    }
}
