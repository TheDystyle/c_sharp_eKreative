using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_task_Максимальное_число_из_3_х_цифр
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Trim().Split();
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);
            int c = int.Parse(data[2]);

            int temp;

            if (a < b)
            {
                temp = a;
                a = b; b = temp;
            }
            if (b < c)
            {
                temp = b; b = c; c = temp;
            }

            Console.WriteLine("{0} {1} {2}", a, b, c);

        }
    }
}
