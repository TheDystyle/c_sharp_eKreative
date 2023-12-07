using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _01_task_следующй_предыдущий
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The next char for 'B' (66) is 'C' (67)
            // The previous char for 'B' (66) is 'A' (65)

            // діапазон  від 33 до 126

            // Create an ASCII encoding.
            // конвертуємо із цифри в символ Convert.ToChar(simbol[0])
            Encoding ascii = Encoding.ASCII;

            Byte[] simbol = ascii.GetBytes(Console.ReadLine());

            Console.WriteLine($"The next char for '{Convert.ToChar(simbol[0])}' ({simbol[0]}) is '{Convert.ToChar(simbol[0]+1)}' ({simbol[0]+1}).");
            Console.WriteLine($"The previous char for '{Convert.ToChar(simbol[0])}' ({simbol[0]}) is '{Convert.ToChar(simbol[0] - 1)}' ({simbol[0]-1}).");
        }
    }
}
