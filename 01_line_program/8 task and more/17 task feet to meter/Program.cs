using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_task_feet_to_meter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f = Convert.ToInt16(Console.ReadLine());
            int i = Convert.ToInt16(Console.ReadLine());

            double fMeter = f * 0.3048;
            double iMeter = i * 0.0254;

            double answer = fMeter + iMeter;

            Console.WriteLine("{0}'{1}\" = {2:F2}m.", f, i, answer);

        }
    }
}
/*
*
*
*int f = Convert.ToInt16(Console.ReadLine());
            int i = Convert.ToInt16(Console.ReadLine());

            double footToMeter = f * 12 * 2.54;
            double inchToMeter = i * 2.54;

            double answerMeter = Math.Round(((footToMeter + inchToMeter) / 100), 2);
            Console.WriteLine("{0}\'{1}\" = {2}m.", f, i, answerMeter);
*
*
*
*
*
*
*
 * 
 *          int f = Convert.ToInt16(Console.ReadLine());
            int i = Convert.ToInt16(Console.ReadLine());

            double fMeter = f * 0.3048;
            double iMeter = i * 0.0254;

            double answer = fMeter + iMeter;

            Console.WriteLine("{0}'{1}\" = {2:F2}m.", f, i, answer);
 * 
 * 
 * 
 * 
 * 
 *          int f = Convert.ToInt16(Console.ReadLine());
            int i = Convert.ToInt16(Console.ReadLine());

            double footToMeter = f * 12 * 2.54;
            double inchToMeter = i * 2.54;

            double answerMeter = Math.Round(((footToMeter + inchToMeter) / 100), 2);
            Console.WriteLine("{0}\'{1}\" = {2}m.", f, i, answerMeter);
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * // inch -> meter : 1 * 0.0254 m
            // 1 foot -> meter: 1 * 12 * 0.0254 m

            //6'2" = 1.88m


 string[] data = Console.ReadLine().Trim().Split();

            double foot = double.Parse(data[0]);
            double inch = double.Parse(data[1]);

            double footToMeter = foot * 12 * 2.54;
            double inchToMeter = inch * 2.54;

            int answer = Convert.ToInt16(footToMeter + inchToMeter);

            int answerPart1 = answer / 100;
            int answerPart2 = answer % 100; 

            Console.WriteLine("{0}\'{1}\" = {2}.{3}m.", foot, inch, answerPart1, answerPart2);
 * 
 * 
 * 
 * 
 * 
 * string[] data = Console.ReadLine().Trim().Split();

            double foot = double.Parse(data[0]);
            double inch = double.Parse(data[1]);

            double footToMeter = foot * 12 * 2.54;
            double inchToMeter = inch * 2.54;

            double answerMeter = Math.Round(((footToMeter + inchToMeter)/100), 2);
            Console.WriteLine(answerMeter);
             

            Console.WriteLine("{0}\'{1}\" = {2}m.", foot, inch, answerMeter);
 * 
 */