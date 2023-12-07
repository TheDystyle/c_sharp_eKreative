using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_task_adulthood__18_year_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName1 = Console.ReadLine();
            int adulthood1 = int.Parse(Console.ReadLine()) + 18;
            Console.WriteLine("{0} will reach adulthood in {1}", studentName1, adulthood1);

            string studentName2 = Console.ReadLine();
            int adulthood2 = int.Parse(Console.ReadLine()) + 18;
            Console.WriteLine("{0} will reach adulthood in {1}", studentName2, adulthood2);

            string studentName3 = Console.ReadLine();
            int adulthood3 = int.Parse(Console.ReadLine()) + 18;
            Console.WriteLine("{0} will reach adulthood in {1}", studentName3, adulthood3);





            /* string[] studentNames = Console.ReadLine().Trim().Split();

             string studentName0 = studentNames[0];
             string studentName1 = studentNames[1];
             string studentName2 = studentNames[2];

             string[] yearBirth = Console.ReadLine().Trim().Split();

             int yearBirth0 = int.Parse(yearBirth[0]) + 18;
             int yearBirth1 = int.Parse(yearBirth[1]) + 18;
             int yearBirth2 = int.Parse(yearBirth[2]) + 18;

             Console.WriteLine("{0} will reach adulthood in {1} \n{2} will reach adulthood in {3} \n{4} will reach adulthood in {5} \n", studentName0, yearBirth0, studentName1, yearBirth1, studentName2, yearBirth2);

             */
        }
    }
}
