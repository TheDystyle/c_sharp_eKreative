using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_task_Элементы_с_одинаковыми_знаками
{
    internal class Program
    {
        ////////////////////////////////////   1 variant //////////////////////
        //static int[] InitByKeyBoard(string str1, string str2, int k)
        //{
        //    int n = Convert.ToInt16(str1);

        //    string[] data = str2.Trim().Split(' ');
        //    int[] arr = new int[n + 1];

        //    for (int i = 1; i < n + 1; i++)
        //    {
        //        arr[i] = Int32.Parse(data[i - 1]);
        //    }
        //    //Console.WriteLine($"итерация {k}");
        //    return arr;
        //}

        //static bool CheckSameSign(int[] fullArray)
        //{
        //    bool answerItem = false;
        //    for(int i = 0; i < fullArray.Length-1; i++)
        //    {

        //        //if(i >= 0 && i != fullArray.Length)
        //       // {
        //            if ((fullArray[i] > 0 && fullArray[i+1] > 0) || (fullArray[i] < 0 && fullArray[i+1] < 0))
        //            {
        //                //Console.WriteLine("SUPER!!!!!");
        //                answerItem = true;
        //                break;
        //            }
        //       // }
        //       // if(i == fullArray.Length)
        //       // {
        //         //   if (Math.Sign(fullArray[i - 1]) == Math.Sign(fullArray[i + 1]))
        //       // }
        //    }
        //    return answerItem;
        //}
        ////////////////////////////////////   1 variant //////////////////////

        static int[] InitByKeyBoard(string str1, string str2 )
        {
            int n = Convert.ToInt16(str1);

            string[] data = str2.Trim().Split(' ');
            int[] arr = new int[n + 1];

            for (int i = 1; i < n + 1; i++)
            {
                arr[i] = Int32.Parse(data[i - 1]);
                //Console.WriteLine(arr[i]);
            }
            return arr;
        }

        static void CheckSameSign(int[] fullArray)
        {
            bool answerItem = false;

            for (int i = 1; i < fullArray.Length; i++)
            {
                if ((fullArray[i] > 0 && fullArray[i - 1] > 0) || (fullArray[i] < 0 && fullArray[i - 1] < 0))
                {
                    answerItem = true;
                    break;
                }
            }

            if (answerItem == true)
            {
                Console.WriteLine("YES");
            }
            if (answerItem == false)
            {
                Console.WriteLine("NO");
            }
        }
        static void Main(string[] args)
        {
            int k = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < k; i++)
            {
                int[] fullArray = InitByKeyBoard(Console.ReadLine(), Console.ReadLine());
                CheckSameSign(fullArray);
            }
            
            ///////////////////////////////////////   1 variant //////////////////////
           // Console.OutputEncoding = Encoding.Unicode;

           // int k = Int32.Parse(Console.ReadLine());
           // // создаем к+1 т.к в вайле значение только больше 0. 
           // //если оставить к, то нулевой элемент не заполнится
           // string[] answers = new string[k];

            
           // while (k > 0)
           // {
           //     int[] fullArray = InitByKeyBoard(Console.ReadLine(), Console.ReadLine(), k);
           //     bool answerItem = CheckSameSign(fullArray);

           //     if (answerItem == true)
           //     {
           //         answers[k-1] = "YES";
           //     }
           //     if (answerItem == false)
           //     {
           //         answers[k-1] = "NO";
           //     }

           //     //Console.WriteLine($"element {k} - {answers[k - 1]}");
           //     k--;
           // }

           //Array.Reverse(answers);

           ////Console.WriteLine("\nответы:");
           // for(int i = 0;i < answers.Length; i++)
           // {
           //     Console.WriteLine(answers[i]);
           //     //Console.WriteLine(i);
           // }
            ////////////////////////////////////   1 variant //////////////////////

        }
    }
}
