using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard.ViewComponents
{
    public class ArticleViewComponent :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var article = new List<Article>
            {
                new Article(1, "blog-post-thumb-Card-1.jpg", "3 تا از بهرین اسکریبت ها",
                    "این سه تا اسکریپت یکی از بهترین اسکریپت های  دنیا هستند"),
                new Article(2, "blog-post-thumb-Card-2.jpg", "بازار دور کاری",
                    "دور کاری یکی از  بهترین نحوه های کار کردن است"),
                new Article(3, "blog-post-thumb-Card-3.jpg", "راهنمایی برای فول استک شدن",
                    "راهنمای برای  تبدیل شدن به فولستک  شدن"),
            };
            return View("_article", article);
        }
    }
}
