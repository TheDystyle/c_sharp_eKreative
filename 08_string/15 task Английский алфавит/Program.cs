using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_task_Английский_алфавит
{
    internal class Program
    {
        static void Alfabet(string firstLiteral, string secondLiteral)
        {
            char[] chars = new Char[2];
            chars[0] = char.Parse(firstLiteral);
            chars[1] = char.Parse(secondLiteral);

            Array.Sort(chars);
            int counter = Math.Abs((byte)chars[0] - (byte)chars[1])+1;
            int startPosition = (int)chars[0];
            //Console.WriteLine(startPosition);
            while (counter > 0)
            {
                Console.Write($"{(char)(startPosition-32)}{(char)(startPosition)} ");
                startPosition++;
                counter --;
            }
           
        }
        static void Main(string[] args)
        {
            Alfabet(Console.ReadLine(),Console.ReadLine());
        }
    }
}
