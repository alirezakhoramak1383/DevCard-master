using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "لطفا نام خود را وارد کنید")]
        [MinLength(2, ErrorMessage = "نام کمتر از 2 کارکتر مجاز نیست")]
        [MaxLength(100, ErrorMessage = "نام بیشتر از 100 کارکتر مجاز نیست")]
        public string name { get; set; }
        [Required(ErrorMessage = "لطفا ایمیل خود را وارد کنید")]
        [EmailAddress(ErrorMessage = "این مقدار ایمل نیست")]
        public string email { get; set; }
        public string service { get; set; }
        public string message { get; set; }
        public SelectList Services { get; set; }
    }
}
