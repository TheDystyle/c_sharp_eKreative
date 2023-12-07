using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_task_Удвоение_символа_z
{
    internal class Program
    {
        static void DoubleSymbolZ(string text)
        {
            string inputText = text;

            //створюємо стрінг-білдер
            //і на кожній ітерації в кінець ПУСТОГО рядка
            //додаємо символ з ТЕКСТ і подвюємо його

            StringBuilder newText = new StringBuilder();
            foreach (var item in text)
            {
                if(item.ToString() == "z")
                {
                    newText.Append(item.ToString() + item.ToString());
                }
                else
                {
                    newText.Append(item.ToString());
                }
                
            }
            Console.WriteLine(newText.ToString());
        }
        static void Main(string[] args)
        {
            DoubleSymbolZ(Console.ReadLine());
        }
    }
}
