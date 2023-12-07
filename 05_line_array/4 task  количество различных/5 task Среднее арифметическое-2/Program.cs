using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_task_Среднее_арифметическое_2
{
    internal class Program
    {
        static int[] InitByKeyBoard(string str1, string str2)
        {
            int n = Convert.ToInt16(str1);

            string[] data = str2.Trim().Split(' ');
            int[] arr = new int[n + 1];

            for (int i = 1; i < n + 1; i++)
            {
                arr[i] = Int32.Parse(data[i - 1]);
            }
           
            return arr;
        }

        public static bool SimpleItem(int item)
        {
            for (int i = 2; i < item; i++)
            {
                if (item % i == 0)
                    return false;
            }
            return true;
        }

        static void AverageNotPairItemOnPairPosition(int[] fullArray)
        {
            double average = 0;

            double sum = 0;
            double count = 0;

            for (int i = 0; i < fullArray.Length; i++)
            {

                if (SimpleItem(Math.Abs(fullArray[i])) && Math.Abs(fullArray[i]) != 1 && fullArray[i] != 0)
                {
                    sum += fullArray[i];
                    count++;
                }

            }

            if (count == 0)
            {
                Console.WriteLine($"{0:F4}");
            }
            else
            {
                average = sum / count;
                Console.WriteLine($"{average:F4}");
            }
        }
        static void Main(string[] args)
        {
           AverageNotPairItemOnPairPosition(InitByKeyBoard(Console.ReadLine(), Console.ReadLine()));
        }
    }
}
 /*  int numb = Convert.ToInt32(Console.ReadLine());

        int start = 2;
            //перевірка на просте число:
            //якщо ділення числа на iтий елемент має залишок і і-тий елемент МЕНШЕ корня квадратного з заданого числа
            //додаємо 1- перевірка наступного числа
            while (numb % start != 0 && start <= Math.Sqrt(numb))
            {
                start++;
            }
            //якщо просте число знайдено
            //перевіряємо чи ділиться задане число на знайдене просте
            if (numb % start == 0)
                Console.WriteLine(start);
            else { Console.WriteLine(numb); }*/