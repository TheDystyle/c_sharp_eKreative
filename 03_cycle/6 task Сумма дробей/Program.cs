using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_task_Сумма_дробей
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numX = Convert.ToDouble(Console.ReadLine());
            int n = 1;
            int m = 1;
            double sum = 0;

            double sumDivisionN = 0;
            double sumDivisionM = 0;

            double epsilon = 1E-6;

            while (true)
            {
                if (sumDivisionN > numX - epsilon) break;
                sumDivisionN = sumDivisionN + 1.0 / n;
                n++;
            }

            //sum = 0;
            while (true)
            {
                if (sumDivisionM > numX + epsilon) break;
                sumDivisionM = sumDivisionM + 1.0 / m;
                m++;
            }
            Console.WriteLine($"{n - 2} {m - 1}");
            
        }
    }
}
/*
 * 
 * 
 * 
 * 
 * 
 * 
 * //Console.WriteLine("{0} {1}", n - 2, m - 1);

            /*double x = Convert.ToDouble(Console.ReadLine());

            int n = 1;
            int m = 1;

            double sumDivisionN = 0;
            double sumDivisionM = 0;
            double epsilon = 1E-6;

            while (true)
            {
                if (sumDivisionN > (x - epsilon)) break;
                sumDivisionN = sumDivisionN + 1.0 / n;
                n++;
                
            }

            while (true)
            {
                if (sumDivisionM > (x + epsilon)) break;
                sumDivisionM = sumDivisionM + 1.0 / n;
                m++;

            }
            Console.WriteLine($"{n-2} {m}");*/