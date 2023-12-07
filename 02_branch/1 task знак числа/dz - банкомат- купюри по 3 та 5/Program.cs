using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz___банкомат__купюри_по_3_та_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int summ = Convert.ToInt32(Console.ReadLine());

                int point = summ % 10;

                //int counter3 = 0;
                int counter5 = 0;

                //int temp3 = 0;
                //int temp5 = 0;

                if (summ >= 1 && summ < 8)
                {
                    Console.WriteLine("Enter a sum > 7");
                }
                else
                {
                    switch (point)
                    {
                        case 0: counter5 = summ / 5; Console.WriteLine("{0} - 5 UAH bills\n", counter5); break;
                        case 1: counter5 = (summ - 6) / 5; Console.WriteLine("{0} - 5 UAH bills\n2 - 3 UAH bills\n", counter5); break;
                        case 2: counter5 = (summ - 12) / 5; Console.WriteLine("{0} - 5 UAH bills\n4 - 3 UAH bills\n", counter5); break;
                        case 3: counter5 = (summ - 3) / 5; Console.WriteLine("{0} - 5 UAH bills\n1 - 3 UAH bills\n", counter5); break;
                        case 4: counter5 = (summ - 9) / 5; Console.WriteLine("{0} - 5 UAH bills\n3 - 3 UAH bills\n", counter5); break;
                        case 5: counter5 = summ / 5; Console.WriteLine("{0} - 5 UAH bills\n", counter5); break;
                        case 6: counter5 = (summ - 6) / 5; Console.WriteLine("{0} - 5 UAH bills\n2 - 3 UAH bills\n", counter5); break;
                        case 7: counter5 = (summ - 12) / 5; Console.WriteLine("{0} - 5 UAH bills\n4 - 3 UAH bills\n", counter5); break;
                        case 8: counter5 = (summ - 3) / 5; Console.WriteLine("{0} - 5 UAH bills\n1 - 3 UAH bills\n", counter5); break;
                        case 9: counter5 = (summ - 9) / 5; Console.WriteLine("{0} - 5 UAH bills\n3 - 3 UAH bills\n", counter5); break;
                    }
                }
            }
            

        }
    }
}
