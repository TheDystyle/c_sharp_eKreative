using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_task_Количество_различных_2
{
    internal class Program
    {
        static int[] InitByKeyBoard(string str)
        {
            string[] date = str.Trim().Split();
            int[] arr = new int[date.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Int32.Parse(date[i]);
            }
            return arr;
        }

        static int CounterDifferentItem(int[] arr)
        {
            int counter = 1;
            int temp = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != temp)
                {
                    counter++;
                }
                temp = arr[i];
            }
            return counter;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt16(Console.ReadLine());
            int[] myArr = InitByKeyBoard(Console.ReadLine());
            Array.Sort(myArr);
            /*for(int i= 0; i < myArr.Length; i++)
            {
                Console.WriteLine(myArr[i]);
            }*/
            int counter = CounterDifferentItem(myArr);
            Console.WriteLine(counter);
        }
    }
}
/*
 *  // вводимо елементи масиву однією строчкою
        static int[] InputByKeyBoardString(string str, int n)
        {
            string[] date = str.Trim().Split();
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Int32.Parse(date[i]);
            }
            return arr;
        }

        static void CounterDifferentItem(int[] arr)
        {
            int counter = 0;
            int temp = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != temp)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }

 static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            //void - якщо нічого не повертає

            int n = Int32.Parse(Console.ReadLine());

            //заповнюємо масив елементами
            int[] myNumbers = InputByKeyBoardString(Console.ReadLine(), n);

            //рахуэмо кількість різних
            CounterDifferentItem(myNumbers);
        }
*/