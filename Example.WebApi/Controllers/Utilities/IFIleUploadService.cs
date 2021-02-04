using Example.Models.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Example.WebApi.Controllers.Utilities
{
    public interface IFileUploadService
    {
        string GetBaseUrl();
        FileResponseModel<string> UploadFIle(IFormFile file, string uploadFolderName, string extensions = ".pdf,.png,.jpeg,.jpg,.docx,.doc,.avi,.mp4", long maxSize = 5);
    }
}