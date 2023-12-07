using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_task_среднее_арифметическое
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.MaxValue;
            double sum = 0;
            int counter = 0;

            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                counter++;
                sum = sum + n;
            }
            while (n != 0);
            
            sum = sum / (counter - 1);
            Console.WriteLine(sum);
        }
    }
}
