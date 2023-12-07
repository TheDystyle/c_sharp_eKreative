using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_task_Маша_и_конфеты
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Trim().Split();
            int grn = int.Parse(num[0]);
            int kop = int.Parse(num[1]);

            grn = grn * 100;
            int sum = grn + kop;

            int sumView = 0;
            int grnView = 0;
            int kopView = 0;
            
            for (int i = 1; i <= 10; i++)
            {
                if (i < 10)
                {
                    sumView = sum * i;
                    //Console.WriteLine("sum - " + sumView);

                    grnView = sumView / 100;
                   // Console.WriteLine("grn - " + grnView);

                    kopView = sumView - (grnView * 100);
                    // Console.WriteLine("kop - " + kopView);
                    Console.WriteLine(" {0} kg: {1},{2:00} UAH", i, grnView, kopView);
                    /*if (kopView < 10)
                    {
                        Console.WriteLine(" {0} kg: {1},0{2} UAH", i, grnView, kopView);
                    }
                    else
                    {
                        Console.WriteLine(" {0} kg: {1},{2} UAH", i, grnView, kopView);
                    }*/
                    
                   
                   
                }
                else
                {
                    sumView = sum * i;
                   // Console.WriteLine("sum - " + sumView);

                    grnView = sumView / 100;
                   // Console.WriteLine("grn - " + grnView);

                    kopView = sumView - (grnView * 100);
                    Console.WriteLine(" {0} kg: {1},{2:00} UAH", i, grnView, kopView);
                    // Console.WriteLine("kop - " + kopView);
                    /*if (kopView < 10)
                    {
                        Console.WriteLine("{0} kg: {1},0{2} UAH", i, grnView, kopView);
                    }
                    else
                    {
                        Console.WriteLine("{0} kg: {1},{2} UAH", i, grnView, kopView);
                    }*/

                }
            }
            

        }
    }
}


/*
 * кубит пропустил
 * string[] num = Console.ReadLine().Trim().Split();
            int grn = int.Parse(num[0]);
            int kop = int.Parse(num[1]);

            grn = grn * 100;
            int sum = grn + kop;

            int sumView = 0;
            int grnView = 0;
            int kopView = 0;
            
            for (int i = 1; i <= 10; i++)
            {
                if (i < 10)
                {
                    sumView = sum * i;
                    //Console.WriteLine("sum - " + sumView);

                    grnView = sumView / 100;
                   // Console.WriteLine("grn - " + grnView);

                    kopView = sumView - (grnView * 100);
                    // Console.WriteLine("kop - " + kopView);
                    Console.WriteLine(" {0} kg: {1},{2:00} UAH", i, grnView, kopView);
                    /*if (kopView < 10)
                    {
                        Console.WriteLine(" {0} kg: {1},0{2} UAH", i, grnView, kopView);
                    }
                    else
                    {
                        Console.WriteLine(" {0} kg: {1},{2} UAH", i, grnView, kopView);
                    }
                    
                   
                   
                }
                else
{
    sumView = sum * i;
    // Console.WriteLine("sum - " + sumView);

    grnView = sumView / 100;
    // Console.WriteLine("grn - " + grnView);

    kopView = sumView - (grnView * 100);
    Console.WriteLine(" {0} kg: {1},{2:00} UAH", i, grnView, kopView);
    // Console.WriteLine("kop - " + kopView);
    /*if (kopView < 10)
    {
        Console.WriteLine("{0} kg: {1},0{2} UAH", i, grnView, kopView);
    }
    else
    {
        Console.WriteLine("{0} kg: {1},{2} UAH", i, grnView, kopView);
    }

}
            }
 * 
 * 
 * 
 * 
 * ////працюе коректно в системі - кубік не приймає
 * 
 * string[] num = Console.ReadLine().Trim().Split();
            float grn = float.Parse(num[0]);
            float kop = float.Parse(num[1]);

            kop = kop / 100;
            float sum = grn + kop;

            float sumView = 0;

            for(int i = 1; i <= 10; i++) 
             { 
                 if (i < 10)
                 {
                     sumView = sum * i;
                     Console.WriteLine(" {0} kg: {1:F2} UAH", i, sumView);
                 }
                 else
                 {
                     sumView = sum * i;
                     Console.WriteLine("{0} kg: {1:F2} UAH", i, sumView);
                 }

             }
 * 
 * другий робочій варіант
 * 
 * /* string[] num = Console.ReadLine().Trim().Split();
             double grn = double.Parse(num[0]);
             double kop = double.Parse(num[1]);

             double sum1Kg = grn * 100 + kop;
             double sumView = 0;

             Console.WriteLine(sum1Kg);
             Console.WriteLine(sumView);

             for (int i = 1; i <= 10; i++)
             {
                 if (i < 10)
                 {
                     sumView = sum1Kg  * i;
                     Console.WriteLine(" {0} kg: {1:f2} UAH", i, sumView/100);
                 }
                 else
                 {
                     sumView = sum1Kg * i;
                     Console.WriteLine("{0} kg: {1:f2} UAH", i, sumView/100);
                 }

             }*/

