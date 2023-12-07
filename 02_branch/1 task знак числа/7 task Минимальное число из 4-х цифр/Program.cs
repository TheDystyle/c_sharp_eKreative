using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_task_Минимальное_число_из_4_х_цифр
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            int a = number / 1000;
            int b = number % 1000 / 100;
            int c = number % 100 / 10;
            int d = number % 10;

            int midle1;
            int midle2;
            int midle3;

            int position1 = -1;
            int position2 = -1;
            int position3 = -1;
            int position4 = -1;

            int maxAB = Math.Max(a, b);
            if (maxAB > a)
            {
                midle1 = a;
            }
            else
            {
                midle1 = b;
            }

            int maxCD = Math.Max(c, d);
            if (maxCD > c)
            {
                midle2 = c;
            }
            else
            {
                midle2 = d;
            }

            position4 = Math.Max(maxAB, maxCD);
            if (position4 > maxAB)
            {
                midle3 = maxAB;
            }
            else
            {
                midle3 = maxCD;
            }

            int maxMidle12 = Math.Max(midle1, midle2);

            if (maxMidle12 > midle3)
            {
                int min;

                position3 = maxMidle12;
                if (midle1 > midle2)
                {
                    min = midle2;
                }
                else
                {
                    min = midle1;
                }

                if (min > midle3)
                {
                    position2 = min;
                    position1 = midle3;
                }
                else
                {
                    position2 = midle3;
                    position1 = min;
                }
            }

            else
            {
                position3 = midle3;
                if (midle1 > midle2)
                {
                    position2 = midle1;
                    position1 = midle2;
                }
                else
                {
                    position1 = midle1;
                    position2 = midle2;
                }
            }
            
            // if number include "zero" 
            if (position1 == 0 || position2 == 0 || position3 == 0 || position4 == 0)
            {
                if (position1 == 0 && position2 == 0 && position3 == 0)
                {
                    Console.WriteLine("{0}{1}{2}{3}", position4, position1, position3, position2);
                }

                if (position1 == 0 && position2 == 0 && position3 != 0)
                {
                    Console.WriteLine("{0}{1}{2}{3}", position3, position1, position2, position4);
                }

                if (position1 == 0 && position2 != 0  && position3 != 0)
                {
                    Console.WriteLine("{0}{1}{2}{3}", position2, position1, position3, position4);
                }
            } 
            else
            {
                Console.WriteLine("{0}{1}{2}{3}", position1, position2, position3, position4);
            }
        }
    }
}
