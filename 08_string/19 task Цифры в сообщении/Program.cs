using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_task_Цифры_в_сообщении
{
    internal class Program
    {
        static void NumberInString(string data, ref int sumNumbers, ref int count)
        {

            for (int i = 0; i < data.Length; i++)
            {
                if ((byte)data[i] >= 48 && (byte)data[i] <= 57)
                {
                    count++;
                    sumNumbers += (data[i] - 48);
                }

            }

        }
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            int count = 0;
            int sumNumbers = 0;
            NumberInString(data, ref sumNumbers, ref count);
            Console.WriteLine($"{count}\n{sumNumbers}");
        }
    }
}


