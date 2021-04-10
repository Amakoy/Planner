using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Code
{
    public abstract class text
    {
        public abstract void message();
    }

    public class opening : text
    {
        public override void message()
        {
            Console.WriteLine("Menu : \n1 = Add Activity \n2 = Show Schedule \n3 = Delete Activity \n4 = Replace Activity \n5 = exit");
        }
    }
}
