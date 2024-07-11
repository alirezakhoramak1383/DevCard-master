using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard.Models;

namespace DevCard.Data
{
    public class ProjectStore
    {
        public static List<Project> GetProjects()
        {
            return new List<Project>
            {
                new Project(1,"تاکسی","project-1.jpg","در خواست تاکسی برای سفر های درون شهری","snapp"),
                new Project(2,"زود فود ","project-2.jpg","در خواست آنلاین غذا برای سراسر کشور","zoodfood"),
                new Project(3,"مدارس","project-3.jpg","سیستم مدیریت یکپارچه مدارس","MONOP"),
                new Project(4,"فضا پیما","project-4.jpg","برنامه مدیریت فضا پیما های ناسا","NASA")
            };
        }
    }
}
