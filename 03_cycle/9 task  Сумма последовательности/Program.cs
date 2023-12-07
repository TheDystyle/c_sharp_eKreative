using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_task__Сумма_последовательности
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int counter = 0;

            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                counter = counter + n;
            }
            while(n != 0);

            Console.WriteLine(counter);
        }
    }
}
