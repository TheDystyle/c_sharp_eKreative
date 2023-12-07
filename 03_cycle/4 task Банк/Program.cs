using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_task_Банк
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            string[] numbs = num.Split(' ');

            double n = double.Parse(numbs[0]);
            double p = double.Parse(numbs[1]);
            double m = double.Parse(numbs[2]);

            int counter = 0;
            double roundProcent = 0;

            while (n < m)
            {
                roundProcent = n / 100 * p;
                if (roundProcent % 2 == 0)
                {
                    roundProcent = roundProcent - roundProcent % 1;
                }
                else
                {
                    roundProcent = roundProcent - roundProcent % 0.01;
                }
                counter++;
                n += roundProcent;


            }
            System.Console.WriteLine(counter);
        }
    }
}

/*
 * кароч до банка треба умова така в задачці з банком, що якщо число парне то %1, якщо ні то %0.01;
 * 
 *формула с кладних відсотків
 *
N = M*(1 + P/100)^t
От оце t - це наш період.
 * 
 * моє з округленням
 * 
 * 
 * string[] data = Console.ReadLine().Trim().Split();
            decimal n = decimal.Parse(data[0]);
            decimal p = decimal.Parse(data[1]);
            decimal m = decimal.Parse(data[2]);

            decimal prirost = n * p / 100;
            decimal roundProcent = 0;
            roundProcent = Math.Floor(prirost*100)/100;
            decimal newSum = n + roundProcent;

            int counter = 1;

            while (newSum < m)
            {
                prirost = newSum * p / 100;
                roundProcent = Math.Floor(prirost * 100) / 100;
                newSum = newSum + roundProcent;
                counter++;
            }
            
            Console.WriteLine(counter);
 * 
 * 
 * моє без округлення
 * 
 *  string[] data = Console.ReadLine().Trim().Split();
            double n = double.Parse(data[0]);
            double p = double.Parse(data[1]);
            double m = double.Parse(data[2]);

            double newSum = 0;
            newSum = (n * p)*0.01;
           // Console.WriteLine($"start point: \nstert sum - {n} \npercent - {p} \nend sum - {m}\nnewSum - {newSum}");

            int counter = 1;
           
            newSum = n + (n * p)*0.01;
           
           

            while (newSum < m)
            {
                newSum = newSum + (n * p) * 0.01;
                //Console.WriteLine(newSum+"\n");
                counter++;
            }
            
            Console.WriteLine(counter);
        
 * 
 * 
 * 
 * 
 * 
 * 
 * вариант Игоря Базика
 * string[] n = Console.ReadLine().Trim().Split();
            int N = int.Parse(n[0]);
            int P = int.Parse(n[1]);
            int M = int.Parse(n[2]);

            int Time = 0;
            double rez = N;
            double procent = P / 100.0 + 1;

            while (rez < M)
            {
                rez *= procent;
                rez = Math.Floor(rez * 100) / 100;
                Time++;
            }

            Console.WriteLine(Time);
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * Від Слави
 string num = Console.ReadLine();
        string[] numbs = num.Split(" ");
       
        double n = double.Parse(numbs[0]);
        double p = double.Parse(numbs[1]);
        double m = double.Parse(numbs[2]);
  
        int count = 0;
    

        while (n<m) {
            double r = n/100*p;
            if (r%2==0) {
                r = r-r%1;
            } else {
                r = r-r%0.01;
            }
            count++;
            n += r;

            
        }
        System.Console.WriteLine(count);
/*
* */

