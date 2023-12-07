using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_task_Маша_и_изюм
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] num = Console.ReadLine().Split('.');
            int grn = int.Parse(num[0]);
            int kop = int.Parse(num[1]);

           // Console.WriteLine(grn);
           // Console.WriteLine(kop);

            grn = grn * 100;
            kop = kop * 10;
            int sum100g = (grn + kop)/10;

            int grnView = 0;
            int kopView = 0;
            int sumView = 0;

        // Console.WriteLine(sum100g);

            for (int i = 1; i <= 15; i++)
            {
                if (i < 10)
                {
                    sumView = sum100g * i;
                    //Console.WriteLine("sum - " + sumView);

                    grnView = sumView / 100;
                   // Console.WriteLine("grn - " + grnView);

                    kopView = sumView - (grnView * 100);
                    //Console.WriteLine("kop - " + kopView + "\n");

                    Console.WriteLine($" {i * 100} grams: {grnView} UAH {kopView} kop");
                }
                else
                {
                    sumView = sum100g * i;
                    //Console.WriteLine("sum - " + sumView);

                    grnView = sumView / 100;
                    // Console.WriteLine("grn - " + grnView);

                    kopView = sumView - (grnView * 100);
                    //Console.WriteLine("kop - " + kopView + "\n");

                    Console.WriteLine($"{i * 100} grams: {grnView} UAH {kopView} kop");
                }
            }
        }
    }
}
/*
 * 
 * 
            string[] date = Console.ReadLine().Split('.');
            int hrn = int.Parse(date[0]);
            int cent = int.Parse(date[1]);
            int weight;
            int priceKg = hrn * 100 + cent;
            for (int i = 1; i <= 15; i++)
            {
                weight = i * 100;
                int value = i * priceKg;
                // Console.WriteLine(value);
                int cost1 = value / 100 / 10;
                int cost2 = value % 100;
                Console.WriteLine("{1,4} grams: {0} UAH {2} kop", cost1, weight, cost2);
            }

 * 
 * 
 * 
 * 
 * */