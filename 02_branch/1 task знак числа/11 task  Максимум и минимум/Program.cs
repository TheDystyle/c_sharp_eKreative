using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_task__Максимум_и_минимум
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Trim().Split();

            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);

            if (a > b)
            {
                Console.WriteLine(Math.Pow(a, 2));
                Console.WriteLine(Math.Pow(b, 2));
            }
            else
            {
                Console.WriteLine(Math.Pow(b, 2));
                Console.WriteLine(Math.Pow(a, 2));
            }
        }
    }
}
