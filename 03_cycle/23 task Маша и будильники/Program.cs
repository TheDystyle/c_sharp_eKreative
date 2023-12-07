using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_task_Маша_и_будильники
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] time = Console.ReadLine().Split();
            int h = int.Parse(time[0]);
            int min = int.Parse(time[1]);
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0:D2}:{1:D2}", h, min);
                min = min + 5;
                if (min >= 60)
                {
                    h = h + 1;
                    min = min - 60;
                }
                if (h >= 24)
                {
                    h = 0;
                }
            }
                
        }
    }
}
