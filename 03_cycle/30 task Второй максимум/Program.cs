using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_task_Второй_максимум
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
           
            int first = int.MinValue;
            int second = int.MinValue;

            do
            {
                if (n > first && n > second)
                {
                    second = first;
                    first = n;
                }
                else
                {
                    if (n == -2147483648)
                    {
                        second = n;
                    }
                    else
                    {
                        if (n > second)
                        {
                            second = n;
                        }
                    }
                    
                }
               
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n != 0);

            Console.WriteLine(second);
        }
    }
}