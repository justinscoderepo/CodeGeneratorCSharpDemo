using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BotDetect.Web;

namespace Example.WebApi.Controllers
{
    // [Produces("application/json")]
    [ApiController]
    // // [Route("basic-captcha")]
    public class ApiBaseController : Controller
    {

        // // [HttpPost]
        // // public IActionResult Post([FromBody] Models.BasicFormModel data)
        // // {
        // //     Console.WriteLine("In");
        // //     // create a captcha instance to be used for the captcha validation
        // //     SimpleCaptcha captcha = new SimpleCaptcha();
        // //     // execute the captcha validation
        // //     bool isHuman = captcha.Validate(data.UserEnteredCaptchaCode, data.CaptchaId);
        // //     Console.WriteLine("isHuman : ", isHuman.ToString());
        // //     // create an object that stores the validation result
        // //     Dictionary<string, bool> validationResult = new Dictionary<string, bool>();

        // //     if (isHuman == false)
        // //     {
        // //         // captcha validation failed
        // //         validationResult.Add("success", false);
        // //         // TODO: consider logging the attempt
        // //     }
        // //     else
        // //     {
        // //         // captcha validation succeeded
        // //         validationResult.Add("success", true);
        // //     }

        // //     // return the json string with the validation result to the frontend
        // //     return Json(validationResult);
        // // }
    }
}
