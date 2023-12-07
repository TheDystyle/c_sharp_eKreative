using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_задача_using_рамка_из_звездочек
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte inputNumber = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("*****");
            Console.WriteLine("*" + inputNumber + "*");
            Console.WriteLine("*****");
        }
    }
}