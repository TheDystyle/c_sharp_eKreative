using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_task__Результаты_олимпиады
{
    internal class Program
    {
        static int[] InputItemArrayByKeyboard(string nString, string mString)
        {
           //отримуємо на вхід кількість елементів Н і строчку з елементами
           //заповнюємо масив
            int n = Int32.Parse(nString);
            int[] fullArray = new int[n];
            string[] data = mString.Trim().Split();

            for (int i = 0; i < fullArray.Length; i++)
            {
                fullArray[i] = Int32.Parse(data[i]);
            }
            
            return fullArray;
        }

        static void SortByItemPrintID(int[] fullArray)
        {
            //створимо паралельно масив індексів невідсортованого початкового масиву
            int[] newArr = new int[fullArray.Length];
            for (int i = 0; i < fullArray.Length; i++)
            {
                newArr[i] = i + 1;
               //Console.WriteLine(newArr[i]);
            }

            // примінимо сортування бульбашкою
            // одночасно сортуємо початковий масив і новий масив з індексами
            int n = fullArray.Length;
            int tempItem = 0;
            int tempIndex = 0;


            for (int i = 0; i < n - 1; ++i)
            {
                for (int j = 0; j < n - i - 1; ++j)
                {
                    if (fullArray[j + 1] > fullArray[j])
                    {
                        //тут сортуємо початковий масив
                        tempItem = fullArray[j + 1];
                        fullArray[j + 1] = fullArray[j];
                        fullArray[j] = tempItem;

                        //одночастно сортуємо новий масив з індексами
                        tempIndex = newArr[j + 1];
                        newArr[j + 1] = newArr[j];
                        newArr[j] = tempIndex;
                    }
                }
            }

            //виводимо відсортований новий масив індексів
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.Write($"{newArr[i]} ");
            }

        }
        static void Main(string[] args)
        {
            int[] fullArray = InputItemArrayByKeyboard(Console.ReadLine(), Console.ReadLine());
            SortByItemPrintID(fullArray);
        }
    }
}
