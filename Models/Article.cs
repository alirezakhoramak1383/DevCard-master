using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard.Models
{
    public class Article
    {
        public long ID { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Discription { get; set; }

        public Article(long Id, string image, string title, string discription)
        {
            ID = Id;
            Image = image;
            Title = title;
            Discription = discription;
        }
    }
}
