using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_task_дроби_ну_и_пусть
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = (8.0+3) / 4;
            double b = (9.0+1) / 3;

            double c = 5.0 / 7;

            double d = (12.0 + 1) / 6;
            double e = (2.0 + 1) / 2;
            

            double proportional = ((a / 1.1 + b) / (2.5 - 0.4 * b)) / c - (((d + 4.5) * 0.375) / (2.75 - e));

            Console.WriteLine(proportional);


            
                
        }
    }
}
