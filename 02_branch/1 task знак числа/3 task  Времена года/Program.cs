using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _3_task__Времена_года
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte month = Convert.ToSByte(Console.ReadLine());

            if (((month >= 1) && (month <= 2)) || (month == 12))
            {
                Console.WriteLine("Winter");
            }
            else if ((month > 2) && (month < 6))
            {
                Console.WriteLine("Spring");
            }
            else if ((month > 5) && (month < 9))
            {
                Console.WriteLine("Summer");
            }
            else if ((month > 8) && (month < 12))
            {
                Console.WriteLine("Autumn");
            }
            else
            {
                Console.WriteLine("Error");
            }

        }
    }
}
/*
 *
 * /*if 
                    else
                    {
                        if 
                    }
                }
 *
 *
 *
 *
 *
 *
 *last program to QBit
 *
 *
            byte month = Convert.ToByte(Console.ReadLine());

            if (((month > 0) && (month < 3)) || (month == 12))
            {
                Console.WriteLine("Winter");
            }
            else
            {
                if ((month > 2) && (month < 6))
                {
                    Console.WriteLine("Spring");
                }
                else
                {
                    if ((month > 5) && (month < 9))
                    {
                        Console.WriteLine("Summer");
                    }
                    else
                    {
                        if ((month > 8) && (month < 12)) 
                        {
                            Console.WriteLine("Autumn");
                        }
                        else
                        {
                            Console.WriteLine("Error");
                        }
                    }
                }
            }
 *
 *
 *
 
 
 byte month = Convert.ToByte(Console.ReadLine());

            if ((month < 1) || (month > 12))
            {
                Console.WriteLine("Error");
            }

            else
            {
                switch (month)
                {
                    case 1:
                        Console.WriteLine("Winter");
                        break;
                    case 2:
                        Console.WriteLine("Winter");
                        break;
                    case 12:
                        Console.WriteLine("Winter");
                        break;
                    case 3:
                        Console.WriteLine("Spring");
                        break;
                    case 4:
                        Console.WriteLine("Spring");
                        break;
                    case 5:
                        Console.WriteLine("Spring");
                        break;
                    case 6:
                        Console.WriteLine("Summer");
                        break;
                    case 7:
                        Console.WriteLine("Summer");
                        break;
                    case 8:
                        Console.WriteLine("Summer");
                        break;
                    case 9:
                        Console.WriteLine("Autumn");
                        break;
                    case 10:
                        Console.WriteLine("Autumn");
                        break;
                    case 11:
                        Console.WriteLine("Autumn");
                        break;
                }
            }
 
 
 */