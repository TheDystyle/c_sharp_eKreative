using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_task_Длина_последовательности
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.MaxValue;
            int counter = 0;
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                counter++;
            }
            while (n != 0);

            Console.WriteLine(counter-1);

            
        }
    }
}
