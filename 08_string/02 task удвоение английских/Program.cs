using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_task_удвоение_английских
{
    internal class Program
    {
        static void DoubleSymbol(string text)
        {
            string inputText = text;

            //створюємо стрінг-білдер
            //і на кожній ітерації в кінець ПУСТОГО рядка
            //додаємо символ з ТЕКСТ і подвюємо його

            StringBuilder newText = new StringBuilder();
            foreach (var item in text)
            {
                //додаємо подвоєння, якщо букви англ (великі чи маленькі)
                // не  подвоюємо знаки пунктуації та цифри
                //якщо попадаються останні, робимо копію в одному екземплярі

                if( (((byte)item >= 65 && (byte)item <= 90) || ((byte)item >= 97 && (byte)item <= 122)) 
                    && 
                    (item != '.' ||
                    item != ',' ||
                    item != ';' ||
                    item != '-' ||
                    item != ' ' ||
                    item != '(' ||
                    item != ')' ||
                    item != '?' ||
                    item != '!' ||
                    item != '\r' ||
                    item != '\n' ||
                    item != '\t'))
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
            DoubleSymbol(Console.ReadLine());            
        }
    }
}
