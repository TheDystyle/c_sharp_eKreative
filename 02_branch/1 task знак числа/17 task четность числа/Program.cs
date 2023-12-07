using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_task_четность_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int a = Convert.ToInt32(Console.ReadLine());

           if (a %2 == 0)
            {
                Console.WriteLine("{0}", Math.Pow(a, 2));
            }
           else
            {
                Console.WriteLine("{0}", a - 1);
            }
        }
    }
}
