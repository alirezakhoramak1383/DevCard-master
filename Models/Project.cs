using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard.Models
{
    public class Project
    {
        public long Id { get; set; }
        public string  Name { get; set; }
        public string Image { get; set; }
        public string  Discription { get; set; }
        public string Clinet { get; set; }

        public Project(long id, string name, string image, string discription, string clinet)
        {
            Id = id;
            Name = name;
            Image = image;
            Discription = discription;
            Clinet = clinet;
        }
    }
}
