using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Models
{
    public class BasicFormModel
    {
        public string CaptchaId { get; set; }
        public string UserEnteredCaptchaCode { get; set; }
    }
}
