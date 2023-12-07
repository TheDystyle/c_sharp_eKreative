using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_task_Степени_двойки
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            double pow = 1;
            
            while (pow <= n)
            {
                Console.Write($"{pow} ");
                pow *= 2;
            }
        }
    }
}
/*
 * 
            while (pow < n)
            {
                pow = Math.Pow(2, stepen);
                row += pow + " ";
                stepen++;
            }*/