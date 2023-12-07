using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_task__Число_в_горизонтальной_рамке
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string upDown = "";
            int tempN = n;
            int tempRevers = 0;

            while (tempN != 0)
            {
                tempRevers = tempRevers * 10 + tempN % 10;
                tempN /= 10;
                upDown += "*";
            }

            if (n <= 0)
            {
                upDown += "***";
                Console.WriteLine(upDown);
                Console.WriteLine($"*{n}*");
                Console.WriteLine(upDown);
            }
            else
            {
                upDown += "**";
                Console.WriteLine(upDown);
                Console.WriteLine($"*{n}*");
                Console.WriteLine(upDown);
            }
        }
    }
}
/*
             * task 2 revers
             * 
             * int n = Convert.ToInt32(Console.ReadLine());

            int revers = 0;
            int copyN = n;

            while (n != 0)
            {
                revers = revers * 10 + n % 10;
                n /= 10;
            }

            if (copyN == revers)
            {
                Console.WriteLine("Palindrom");
            }
            else
            {
                Console.WriteLine("NOT palindrom");
            }*/