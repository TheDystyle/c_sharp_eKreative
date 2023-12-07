using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_task_Максимальный_элемент
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;
            int n = 1;
            
            while (n != 0)
            {
                n = Convert.ToInt32(Console.ReadLine());

                if (n > max && n !=0)
                {
                    max = n;

                }
                
            }

            Console.WriteLine(max);

        }
    }
    
}
