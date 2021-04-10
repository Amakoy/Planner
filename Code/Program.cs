using System;

namespace Planner.Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Activity[] act = new Activity[5];
            int cek = 0;
            int show = 0;
            int n = 0;
            int i = 0;

            Console.WriteLine("Menu : \n1 = Add Activity \n2 = Show Schedule \n3 = Delete Activity \n4 = Replace Activity \n5 = exit");

            while (cek == 0)
            {
                Console.WriteLine("Ketik command: ");
                int cond = Convert.ToInt32(Console.ReadLine());

                if (cond == 1)
                {
                    addSchedule.a(act, i); //Add
                    i++;
                    n++;
                }

                else if (cond == 2) //Show
                {
                    Console.WriteLine("1 = Semua, 2 = Berdasarkan Kategori");
                    show = Convert.ToInt32(Console.ReadLine());
                    if (show == 1) ShowSchedule.showSchedule(act, n); //show all
                    else if (show == 2) //show category
                    {
                        Mods.showSchedule(act, n);
                    }
                }
                else if (cond == 3) delSchedule.a(act, n); //Delete

                else if (cond == 4) RepSchedule.a(act, n); //Replace

                else if (cond == 5) cek = 1; //Exit
                
            }
        }
    }
}
