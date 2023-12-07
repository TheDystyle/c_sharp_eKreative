using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_task_8_task_Максимальное_число_из_3_х_цифр
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt16(Console.ReadLine());

            int a = number / 100;
            int b = number / 10 % 10;
            int c = number % 10;

            int temp;

            if (a < b)
            {
                temp = b; b = a; a = temp;
            }
            if (a < c)
            {
                temp = c; c = a; a = temp;
            }

            if (b < c)
            {
                temp = c; c = b; b = temp;
            }

            Console.WriteLine("{0}{1}{2}", a, b, c);
        }
    }
}
