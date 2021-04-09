using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner
{
    public class Schedule
    {
        private int cond;
        public Schedule(int cond)
        {
            this.cond = cond;
        }

        public static void addSchedule(Activity[] act, int i)
        {

            Console.WriteLine("Nama aktivitas: ");
            string name = Console.ReadLine();
            Console.WriteLine("Kategori aktivitas: ");
            string kateg = Console.ReadLine();
            Console.WriteLine("Waktu aktivitas: ");
            Console.WriteLine("Bulan (angka): ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tanggal: ");
            int date = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jam (tanpa menit): ");
            int hour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Menit: ");
            int minute = Convert.ToInt32(Console.ReadLine());
            DateTime dt = new DateTime(2020, month, date, hour, minute, 00);
            act[i] = new Activity(name, kateg, dt);

        }

        public static void showSchedule(Activity[] act, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}, Kategori: {1}, Waktu: {2}", act[i].Name, act[i].Category, act[i].dt);
            }
        }

        public static void showSchedule1(Activity[] act, int n, string category)
        {
            int[] j = new int[30];
            int c = 0;
            for (int i = 0; i < n; i++)
            {
                if (String.Equals(category, act[i].Category, StringComparison.InvariantCultureIgnoreCase))
                {
                    j[c] = i;
                    Console.WriteLine(j[c]); 
                    c++;
                }
            }
            
            for (int i = 0; i < c; i++)
            {
                Console.WriteLine("{0}, Kategori: {1}, Waktu: {2}", act[j[i]].Name, act[j[i]].Category, act[j[i]].dt);
            }

        }

        public static void delSchedule(Activity[] act, int n)
        {
            int i = 0;
            while (i < 100)
            {
                i = 0;
                Console.WriteLine("Nama aktivitas yang ingin dihapus: ");
                string test = Console.ReadLine();

#pragma warning disable CS0162 // Unreachable code detected
                for (i = 0; i < n; i++)
#pragma warning restore CS0162 // Unreachable code detected
                {
                    if (String.Equals(test, act[i].Name, StringComparison.InvariantCultureIgnoreCase))break;

                }
                Console.WriteLine("Apakah ingin menghapus aktivitas :");
                Console.WriteLine("{0}, Kategori: {1}, Waktu: {2} ? 1 = Iya, 2 = Tidak, 3 = Exit", act[i].Name, act[i].Category, act[i].dt);
                int ti = Convert.ToInt32(Console.ReadLine());

                if (ti == 1)
                {
                    act[i].Name = "kosong";
                    act[i].Category = "kosong";
                    act[i].dt = new DateTime(0);
                    Console.WriteLine("Berhasil dihapus");
                    return;
                }
                else if (ti == 3) return;
            }



        }
        public static void repSchedule(Activity[] act, int n)
        {
            int i = 0;
            Console.WriteLine("Nama aktivitas yang ingin diganti: ");
            string test = Console.ReadLine();
#pragma warning disable CS0162 // Unreachable code detected
            for (i = 0; i < n; i++)
#pragma warning restore CS0162 // Unreachable code detected
            {
                if (String.Equals(test, act[i].Name, StringComparison.InvariantCultureIgnoreCase)) break;

            }
            addSchedule(act, i);
        }

    }
}
