using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_task___Ровно_одно_из_трёх_условий
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());
            int number4 = Convert.ToInt32(Console.ReadLine());
            int number5 = Convert.ToInt32(Console.ReadLine());
            
            //number1
            int counter1 = 0;

            //first
            if (number1 > 999 && number1 <= 9999)
            {
                int temp1 = number1 / 1000;
                int temp2 = number1 % 1000 / 100;
                int temp3 = number1 % 100 / 10;
                int temp4 = number1 % 10;
                
                if ((temp1 != temp2) && (temp1 != temp3) && (temp1 != temp4) && (temp2 != temp3) && (temp2 != temp4) && (temp3 != temp4))
                {
                        counter1 += 1;
                }
            }

            //second
            if ((number1 %10 == 3) || (number1 %10 == 6) || (number1 %10 == 9))
            {
                counter1 += 1;
            }


            //third
            if (number1 >= 100 && number1 <999)
            {
                int t1 = 0;
                int t2 = 0;
                int t3 = 0;

                t1 = number1 / 100;
                t2 = number1 % 100 / 10;
                t3 = number1 % 10;

                if((t1 == 0) || (t2 == 0) ||(t3 == 0))
                {
                    
                    counter1 += 1;
                }
            }


            if (counter1 == 1)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            //number2
            
            int counter2 = 0;

            if (number2 > 999 && number2 <= 9999)
            {
                int temp12 = number2 / 1000;
                int temp22 = number2 % 1000 / 100;
                int temp32 = number2 % 100 / 10;
                int temp42 = number2 % 10;

                if ((temp12 != temp22) && (temp12 != temp32) && (temp12 != temp42) && (temp22 != temp32) && (temp22 != temp42) && (temp32 != temp42))
                {
                    counter2 += 1;
                }
            }

            if ((number2 % 10 == 3) || (number2 % 10 == 6) || (number2 % 10 == 9))
            {
                counter2 += 1;
            }

            if (number2 >= 100 && number2 < 999)
            {
                int t12 = 0;
                int t22 = 0;
                int t32 = 0;

                t12 = number2 / 100;
                t22 = number2 % 100 / 10;
                t32 = number2 % 10;

                if ((t12 == 0) || (t22 == 0) || (t32 == 0))
                {

                    counter2 += 1;
                }
            }


            if (counter2 == 1)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            //number3
            int counter3 = 0;

            if (number3 > 999 && number3 <= 9999)
            {
                int temp13 = number3 / 1000;
                int temp23 = number3 % 1000 / 100;
                int temp33 = number3 % 100 / 10;
                int temp43 = number3 % 10;

                if ((temp13 != temp23) && (temp13 != temp33) && (temp13 != temp43) && (temp23 != temp33) && (temp23 != temp43) && (temp33 != temp43))
                {
                    counter3 += 1;
                }
            }

            if ((number3 % 10 == 3) || (number3 % 10 == 6) || (number3 % 10 == 9))
            {
                counter3 += 1;
            }

            if (number3 >= 100 && number3 < 999)
            {
                int t13 = 0;
                int t23 = 0;
                int t33 = 0;

                t13 = number3 / 100;
                t23 = number3 % 100 / 10;
                t33 = number3 % 10;

                if ((t13 == 0) || (t23 == 0) || (t33 == 0))
                {

                    counter3 += 1;
                }
            }


            if (counter3 == 1)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            //number4
            int counter4 = 0;

            if (number4 > 999 && number4 <= 9999)
            {
                int temp14 = number4 / 1000;
                int temp24 = number4 % 1000 / 100;
                int temp34 = number4 % 100 / 10;
                int temp44 = number4 % 10;

                if ((temp14 != temp24) && (temp14 != temp34) && (temp14 != temp44) && (temp24 != temp34) && (temp24 != temp44) && (temp34 != temp44))
                {
                    counter4 += 1;
                }
            }

            if ((number4 % 10 == 3) || (number4 % 10 == 6) || (number4 % 10 == 9))
            {
                counter4 += 1;
            }

            if (number4 >= 100 && number4 < 999)
            {
                int t14 = 0;
                int t24 = 0;
                int t34 = 0;

                t14 = number4 / 100;
                t24 = number4 % 100 / 10;
                t34 = number4 % 10;

                if ((t14 == 0) || (t24 == 0) || (t34 == 0))
                {

                    counter4 += 1;
                }
            }


            if (counter4 == 1)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            //number5
            int counter5 = 0;

            if (number5 > 999 && number5 <= 9999)
            {
                int temp15 = number5 / 1000;
                int temp25 = number5 % 1000 / 100;
                int temp35 = number5 % 100 / 10;
                int temp45 = number5 % 10;

                if ((temp15 != temp25) && (temp15 != temp35) && (temp15 != temp45) && (temp25 != temp35) && (temp25 != temp45) && (temp35 != temp45))
                {
                    counter5 += 1;
                }
            }

            if ((number5 % 10 == 3) || (number5 % 10 == 6) || (number5 % 10 == 9))
            {
                counter5 += 1;
            }

            if (number5 >= 100 && number5 < 999)
            {
                int t15 = 0;
                int t25 = 0;
                int t35 = 0;

                t15 = number5 / 100;
                t25 = number5 % 100 / 10;
                t35 = number5 % 10;

                if ((t15 == 0) || (t25 == 0) || (t35 == 0))
                {

                    counter5 += 1;
                }
            }


            if (counter5 == 1)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
