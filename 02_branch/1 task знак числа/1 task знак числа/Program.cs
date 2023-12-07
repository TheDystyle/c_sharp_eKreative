using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_task_знак_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short num = Convert.ToInt16(Console.ReadLine());
            
            if (num == 0) {
                Console.WriteLine(num);
            }

                else {
                    if (num < 0) {
                    Console.WriteLine(Math.Abs(num));
                    }
                        else {
                            if (num > 0)
                             {
                        Console.WriteLine(Math.Pow(num, 2));
                             }
                        }
            }
           
        }
    }
}
