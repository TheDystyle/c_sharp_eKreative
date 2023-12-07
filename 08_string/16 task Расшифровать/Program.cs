using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_task_Расшифровать
{
    internal class Program
    {
        static void Decoding(string count, string numberCollection)
        {
            int n = Int32.Parse(count);
            string[] data = numberCollection.Trim().Split();

            //заповнюємо новий масив байтів значеннями із строчки
            byte[] numbers = new byte[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = byte.Parse(data[i]);
            }

            char[] answer = new char[n];
            for (int i = 0; i < n; i++)
            {
                answer[i] = (char)numbers[i];
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(answer[i]);
            }


        }
        static void Main(string[] args)
        {
            

            //вводимо кількість і числа для деккодування
            //13
            //72 101 108 108 111 44 32 87 111 114 108 100 33
            Decoding(Console.ReadLine(), Console.ReadLine());

        }
    }
}
