using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_task__Наименьший_делитель
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numb = Convert.ToInt32(Console.ReadLine()); 

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
            else { Console.WriteLine(numb); }


        }
    }
}
/*
 * 
 * 
 *     /* знаходимо чи є число простим (ділиться на 1 і само себе)
            int a = 2,
              i = 1;
            Console.WriteLine(1);
            while (i < 10)
            {
                bool simple = true;

                for (int j = 2; j <= Math.Floor(Math.Sqrt(a)); j++)
                {
               }
                if (simple)
                {
                    Console.WriteLine(a); i++;
                }
                a++;
            }*/
/* 
 * чернетки
 * 
 * 
 * 
            /*int n = Convert.ToInt32(Console.ReadLine());
            //bool simple = true;
            int x = 0;
            
            int start = 2;

            while(start <= n)
            {
                if (n %start == 0)
                { 
                    for(int i=1; i<n; i++)
                    {
                        if (n%i == 0)
                        {
                            Console.WriteLine("false");
                           
                        }
                        else
                        {
                            Console.WriteLine("true");
                            break;
                        }
                    }
                       
                }
                start++;
            }

            Console.WriteLine(start);*/

