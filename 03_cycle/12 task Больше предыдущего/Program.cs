using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_task_Больше_предыдущего
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //нужно сравнивать , если новое введенное больше предыдущего

            int n = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            int first = n;
            
            do
            {
                if (n > first)
                {
                    first = n;
                    counter++;
                }
                else
                {
                    first = n;
                }
                
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n != 0);

            Console.WriteLine(counter);
        }
    }
}
/* 





int n = 0;
            int first = 0;

            while (n != 0)
            {

            }
 
 */