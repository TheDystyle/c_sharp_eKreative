using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            ///
            //EvilStruct es1 = new EvilStruct();
            //es1.PointRef = new PointRef();
            //es1.PointRef.x = 1;
            //es1.PointRef.y = 2;// is same es1.PointRef = new PointRef() {x =1, y = 2};

            /////
            //PointVal a; // same as PointVal a = new PointVal();
            //a.x = 3;
            //a.y = 5;

            //PointVal b = a;
            //b.x = 7;
            //b.y = 10;

            //a.LogValues();
            //b.LogValues();

            //Console.WriteLine("After structs");

            //PointRef c = new PointRef();
            //c.x = 3;
            //c.y = 5;

            //PointRef d = c;
            //d.x = 7;
            //d.y = 10;

            //c.LogValues();
            //d.LogValues();

            //var list = new List<int>();
            //AddNumbers(list);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            ///// передача значений по ссылке и через копирование
            //int a = 1;
            //int b = 2;

            //Console.WriteLine($"before SWAP a = {a}, b = {b}\n");

            //Swap(a, b);
            
            //Console.WriteLine($"after SWAP a = {a}, b = {b}\n \n \n \n");

            //// передача по ссылке 
            //Console.WriteLine($"before SWAP a = {a}, b = {b}\n");

            //RefSwap(ref a, ref b);

            //Console.WriteLine($"after SWAP a = {a}, b = {b}\n");


            // nullable
            //PointVal? pv = null;
            //if(pv.HasValue )
            //{
            //    PointVal pv2 = pv.Value;
            //    Console.WriteLine(pv.Value.x);
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}
        }
        static void AddNumbers(List<int> numbers)
        {
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
        }

        static void Swap(int a, int b)
        {
            Console.WriteLine($"In function:");
            Console.WriteLine($"Original a = {a}, b = {b}");
            int temp = a; a = b; b = temp;
            Console.WriteLine($"Swapped a = {a}, b = {b}\n");
        }

        static void RefSwap(ref int a, ref int b)
        {
            Console.WriteLine($"In function:");
            Console.WriteLine($"Original a = {a}, b = {b}");
            int temp = a; a = b; b = temp;
            Console.WriteLine($"Swapped a = {a}, b = {b}\n");
        }

    }
}
