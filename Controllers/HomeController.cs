using DevCard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualStudio.Web.CodeGeneration;
using Newtonsoft.Json.Linq;

namespace DevCard.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly List<Services> _Services = new List<Services>
        {
            new Services(1, "نقره ای"),
            new Services(2, " طلایی"),
            new Services(3, " پلاتین"),
            new Services(4, " الماس"),
        };
            
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact
            {
                Services = new SelectList(_Services, "Id", "Name")
            };
            return View(model);
        }
        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    var name = form["name"];
        //    return Json(Ok());
        //}
        [HttpPost]
        public IActionResult Contact(Contact form)
        {
            form.Services = new SelectList(_Services, "Id", "Name");
            if (!ModelState.IsValid)
            {
                ViewBag.error = " اطلاعات وارد شده صحیح نمی باشد لطفا دوباره تلاش کنی ";
                return View(form);
            }
            ModelState.Clear();
            form = new Contact
            {
              Services  = new SelectList(_Services, "Id", "Name")
            };
            ViewBag.Succses = "پیام شما با موفقیت ارسال شد ممنون از پیشنهاد تان";
            return View(form);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
