using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_task_Зашифровать
{
    internal class Program
    {
        static void Сoding(string count, string symbolCollection)
        {
            int n = Int32.Parse(count);

            //convert to char collection for convert:
            // char -> byte
            char[] symbols = symbolCollection.ToCharArray();

            byte[] answer = new byte[n];
            for (int i = 0; i < n; i++)
            {
                answer[i] = (byte)symbols[i];
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{answer[i]} ");
            }
        }
        static void Main(string[] args)
        {

            //вводимо кількість і текст
            //13
            // Hello, World!

            //72 101 108 108 111 44 32 87 111 114 108 100 33
            Сoding(Console.ReadLine(), Console.ReadLine());
        }
    }
}
