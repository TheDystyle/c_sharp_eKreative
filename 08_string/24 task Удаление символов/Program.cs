using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _24_task_Удаление_символов
{
    internal class Program
    {
        static void DeleteSubString(string inputText, string position)
        {
            string[] data = position.Trim().Split();
            int n = Int32.Parse(data[0]);
            int m = Int32.Parse(data[1]);

            //визначаємо кількість символів для видалення
            int countSymbols = m - n + 1;
           
            string outText = inputText.Remove(n-1, countSymbols);
            Console.WriteLine(outText);
        }
        static void Main(string[] args)
        {
            DeleteSubString(Console.ReadLine(), Console.ReadLine());
        }
    }
}
