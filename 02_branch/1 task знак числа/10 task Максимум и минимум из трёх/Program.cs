using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_task_Максимум_и_минимум_из_трёх
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int max;

            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }

            if (max < c)
            {
                max = c;
            }

            int min;
            if (a < b)
            {
                min = a;
            }
            else
            {
                min = b;
            }

            if (min > c)
            {
                min = c;
            }

            Console.WriteLine(Math.Pow(max, 2));
            Console.WriteLine(Math.Pow(min, 2));
        }
    }
}
