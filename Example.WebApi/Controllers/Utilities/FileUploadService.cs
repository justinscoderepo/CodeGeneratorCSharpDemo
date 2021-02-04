using Example.Models.Common;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Linq;
// using SixLabors.ImageSharp;
// using SixLabors.ImageSharp.Formats;
// using SixLabors.ImageSharp.Processing;

namespace Example.WebApi.Controllers.Utilities
{
    public class FileUploadService : IFileUploadService
    {
        private IWebHostEnvironment _env;
        private IHttpContextAccessor _httpContextAccessor;
        public FileUploadService(IWebHostEnvironment env, IHttpContextAccessor httpContextAccessor)
        {
            _env = env;
            _httpContextAccessor = httpContextAccessor;
        }
        public string GetBaseUrl()
        {
            var authority = (_httpContextAccessor.HttpContext.Request.Host.Host.Contains(".com") || _httpContextAccessor.HttpContext.Request.Host.Host.Contains(".net")) ? "https://" : "http://";
            var host = GetHost();
            return $"{authority}{host}";
        }
        protected string GetHost()
        {
            return _httpContextAccessor.HttpContext.Request.Host.Value;
        }
        public FileResponseModel<string> UploadFIle(IFormFile file, string uploadFolderName, string extensions = ".pdf,.png,.jpeg,.jpg", long maxSize = 5)
        {
            maxSize = maxSizeInBytes(maxSize);
            string fileExtension = Path.GetExtension(file.FileName).ToLower();

            string[] values = extensions.Split(',');

            if (!values.Contains(fileExtension))
            {
                return new FileResponseModel<string>(file.FileName, $"Not Valid File Extension, Valid Extensions include {extensions}", false);
            }

            if (file.Length > maxSize)
            {
                return new FileResponseModel<string>(file.FileName, "File Size >" + maxSize + "Mb", false);
            }
            var fileUploaded = file;
            var folderName = (_env.ContentRootPath + "\\wwwroot\\" + uploadFolderName + "\\");
            var thumbnailFolderName = folderName + "Thumbnail\\";
            bool exists = System.IO.Directory.Exists(folderName);
            if (!exists)
            {
                System.IO.Directory.CreateDirectory(folderName);
            }

            var pathToSave = folderName;
            var pathToSaveThumbnail = thumbnailFolderName;
            if (fileUploaded != null && fileUploaded.Length > 0)
            {

                var noSpaceFileName = Regex.Replace(fileUploaded.FileName, "[^a-zA-Z0-9_.]+", "");
                var splitingFileName = noSpaceFileName.Split("/");
                noSpaceFileName = splitingFileName[splitingFileName.Length - 1];
                var time = DateTime.UtcNow.Ticks;
                var fileName = time + noSpaceFileName;
                var fullPath = Path.Combine(pathToSave, fileName);
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                var baseurl = GetBaseUrl();
                var url = ($"{baseurl}/{uploadFolderName}/{fileName}");
                return new FileResponseModel<string>(url, "Uploaded Successfully", true, file.Length.ToString(), file.FileName);

            }

            return new FileResponseModel<string>(file.FileName, "Bad Request", false);
        }


        public long maxSizeInBytes(long sizeInMb)
        {
            long sizeInBytes = 0;
            sizeInBytes = sizeInMb * 1024 * 1024;
            return sizeInBytes;
        }

    }
}