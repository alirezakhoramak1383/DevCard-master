using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace DevCard.Models
{
    public class Services
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Services(int ID,string name)
        {
            Id = ID;
            Name = name;
        }
    }
}
