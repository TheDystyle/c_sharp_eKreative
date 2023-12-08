using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_01
{
    internal class Program
    {
        abstract internal class Gadget
        {
            int price = 0;
            string color;
            int height = 0;
            int width = 0;
            int depth = 0;
            int weight = 0;
            

            internal void SetPrice(int price)
            {
                this.price = price;
            }
            internal int GetPrice()
            {
                return price;
            }
            internal void SetColor(string color)
            {
                this.color = color;
            }
            internal string GetColor()
            {
                return color;
            }
            internal void SetHeight(int height)
            {
                this.height = height;
            }
            internal int GetHeight()
            {
                return height;
            }
            internal void SetWidth(int width)
            {
                this.width = width;
            }
            internal int GetWidth()
            {
                return width;
            }
            internal void SetWeight(int weight)
            {
                this.weight = weight;
            }
            internal int GetWeight()
            {
                return weight;
            }
            internal void SetDepth(int depth)
            {
                this.depth = depth;
            }
            internal int GetDepth()
            {
                return depth;
            }
            internal void Scrach()
            {
                price--;
            }
            abstract public void Instalation();
        }

        public class Book : Gadget
        {
            public string assignment;
            public override void Instalation()
            {
               Console.WriteLine("Instalation - book in hands");
            }
        }

        public class Clock : Gadget
        {
            public string assignment;
            public int sizeScreen;
            public override void Instalation()
            {
                Console.WriteLine("Instalation - clock on the hands");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Object book1 - class Book : Gadget");
            Book book1 = new Book();
            book1.assignment = "read text";
            book1.SetColor("red");
            book1.SetPrice(100);
            book1.Instalation();
            
            Console.WriteLine($"assigment = {book1.assignment}");
            Console.WriteLine($"color = {book1.GetColor()}");
            Console.WriteLine($"price = {book1.GetPrice()}");
            Console.WriteLine();

            Console.WriteLine("Object clock - class Clock : Gadget");
            Clock clock1 = new Clock();
            clock1.assignment = "watch time";
            clock1.Instalation();
            clock1.sizeScreen = 13;
            clock1.SetPrice(50);
            

            Console.WriteLine($"assigment = {clock1.assignment}");
            Console.WriteLine($"color = {clock1.sizeScreen}");
            Console.WriteLine($"price before scrach = {clock1.GetPrice()}");
            clock1.Scrach();
            Console.WriteLine($"price after scrach = {clock1.GetPrice()}");
            Console.WriteLine();
        }

        

    }
}

//abstract public class Furniture
//{
//    public int legsCout;
//    public int color;
//    public string material;
//    public int price = 0;

//    public void setPrice(int price)
//    {
//        this.price = price;
//    }

//    public int getPrice()
//    {
//        return price;
//    }

//    public void Scrach()
//    {
//        this.price--;
//    }
//    abstract public void assembly();

//}

//public class Table : Furniture
//{
//    public Table()
//    {
//        setPrice(100);
//    }

//    public override void assembly()
//    {
//        Console.WriteLine("Assembly Table");
//    }
//}

//public class Chair : Furniture
//{
//    public int backHeight;

//    public Chair(int backHeight)
//    {
//        this.backHeight = backHeight;
//        setPrice(50);
//    }

//    public override void assembly()
//    {
//        Console.WriteLine("Assembly Chair");
//    }
//}


// in main
//Table table = new Table();
//table.assembly();
//table.Scrach();
//Chair chair = new Chair(40);

//Furniture[] array = new Furniture[2];
//array[0] = table;
//array[1] = chair;

//int sum = 0;
//foreach (Furniture f in array)
//{
//    sum += f.getPrice();
//}

//Console.WriteLine(sum);
