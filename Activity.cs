using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner
{
    public class Activity
    {
        public string Name;
        public string Category;
        public DateTime dt = new DateTime();

 
        public Activity(string Name, string Category, DateTime dt)
        {
            this.Name = Name;
            this.Category = Category;
            this.dt = dt;
        }


    }

}
