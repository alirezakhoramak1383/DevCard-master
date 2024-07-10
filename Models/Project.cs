using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard.Models
{
    public class Project
    {
        public long ID { get; set; }
        public string  Name { get; set; }
        public string Image { get; set; }
        public string  Discription { get; set; }
        public string Clinet { get; set; }

        public Project(long Id, string name, string image, string discription, string clinet)
        {
            ID = Id;
            Name = name;
            Image = image;
            Discription = discription;
            Clinet = clinet;
        }
    }
}
