using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_task_Первый_пробел
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string txt = Console.ReadLine();
            Console.WriteLine(txt.IndexOf(' ') + 1);
        }
    }
}
