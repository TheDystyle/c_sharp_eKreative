using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_task__Число_наоборот
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long n = Convert.ToInt32(Console.ReadLine());

            long revers = 0;
            
            while (n != 0)
            {
                revers = revers * 10 + n % 10;
                n /= 10;
            }

            Console.WriteLine(revers);  
        }
    }
}
