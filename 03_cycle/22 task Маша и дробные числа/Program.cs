using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_task_Маша_и_дробные_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            double multi = 1.0;
            double start = 1.0;

            for (int i = 0; i < n; i++)
            {
                start = start + 0.1;
                multi *= start;
            }
            Console.WriteLine(multi);
           
        }
    }
}
