using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Удвоение_всех_символов
{
    internal class Program
    {
        static void DoubleAllSymbol(string text)
        {
            string inputText = text;

            //створюємо стрінг-білдер
            //і на кожній ітерації в кінець ПУСТОГО рядка
            //додаємо символ з ТЕКСТ і подвюємо його

            StringBuilder newText = new StringBuilder();
            foreach (var item in text)
            {
                newText.Append(item.ToString() + item.ToString());
            }
            Console.WriteLine(newText.ToString());
        }
        static void Main(string[] args)
        {
            DoubleAllSymbol(Console.ReadLine());
        }
    }
}
