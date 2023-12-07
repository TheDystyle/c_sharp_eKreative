    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_task_Количество_пробелов
{
    internal class Program
    {
        static void CountGap(string text)
        {
            int countGap = 0;
            foreach (var item in text)
            {
                if(item.ToString() == " ")
                {
                    countGap++;
                }
            }
            Console.WriteLine(countGap);
        }
        static void Main(string[] args)
        {
            CountGap(Console.ReadLine());
        }
    }
}
