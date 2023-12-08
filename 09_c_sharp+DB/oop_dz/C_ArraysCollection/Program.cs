using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ArraysCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LIST
            //var intList = new List<int>() { 1,2,3,4,5};
            //foreach (int i in intList)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("=== add item ====");

            //intList.Add(99999);
            //foreach (int i in intList)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("=== add array int[] intArray = {11,22,33}; ====");

            //int[] intArray = {11,22,33};
            //intList.AddRange(intArray);
            //foreach (int i in intList)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("=== delete element by item 1 and by index 3 ====");
            //if (intList.Remove(1)) //first occurence
            //{
            //    //do
            //}
            //else { }

            //intList.RemoveAt(3);
            //foreach (int i in intList)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("=== reverse list ====");
            //intList.Reverse();
            //foreach (int i in intList)
            //{
            //    Console.WriteLine(i);
            //}

            //bool contains = intList.Contains(4);
            //Console.WriteLine(contains);

            //int min = intList.Min();
            //int max = intList.Max();

            //Console.WriteLine($"min = {min}, max = {max}");

            //int indexOff = intList.IndexOf(11);
            //Console.WriteLine($"indexOff = {indexOff}");

            //int lastIndexOf = intList.LastIndexOf(11);
            //Console.WriteLine($"lastIndexOff = {lastIndexOf}");

            //int count = intList.Count;
            //Console.WriteLine(count);

            //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=- DICTIONARY

            //var people = new Dictionary<int, string>();
            //people.Add(1, "John");
            //people.Add(2, "Bob");
            //people.Add(3, "Alice");

            //people = new Dictionary<int, string>()
            //{
            //    { 1, "John" },
            //    { 2, "Bob" },
            //    { 3, "Alice" },
            //};

            //string name = people[1];
            //Console.WriteLine(name);

            //Console.WriteLine("iterating over keys");
            //Dictionary<int, string>.KeyCollection keys = people.Keys;
            //foreach (int item in keys)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("iterating over values");
            //var values = people.Values;
            //foreach (var item in values)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Iterating over key-value pairs");
            //foreach (var pair in people)
            //{
            //    Console.WriteLine($"Key = {pair.Key} Values = {pair.Value}");
            //}
            //Console.WriteLine();

            //Console.WriteLine($"Count = {people.Count}");

            //bool containKey = people.ContainsKey(2);
            //Console.WriteLine($"Contains value by key ={containKey}");

            //bool containValue = people.ContainsValue("John");
            //Console.WriteLine($"Contains item by value ={containValue}");

            //people.Remove(1); // return bool: if removed - true, else false


            //Console.WriteLine();
            //if(people.TryGetValue(2, out string val))
            //{
            //    Console.WriteLine($"Succses. val = {val}");
            //}
            //else
            //{
            //    Console.WriteLine("Fail");
            //}

            //Console.WriteLine();
            //people.Clear();

            //Dictionary

            var json = new Dictionary<string, string>()
            {
                { "date_unix", "" },
                {"temp_kelvin", "" },
                {"feels_like_kelvin", "" },
                {"temp_min_kelvin", "" },
                {"temp_max_kelvin", "" }
            };

            foreach (var pair in json)
            {
                Console.WriteLine(pair.Key + "=" + pair.Value);
            }

            Console.WriteLine();

            json["date_unix"] = "777";

            json["temp_kelvin"] = "777";
            json["feels_like_kelvin"] = "777";
            json["temp_min_kelvin"] = "777";
            json["temp_max_kelvin"] = "777";

            foreach (var pair in json)
            {
                Console.WriteLine(pair.Key + "=" + pair.Value);
            }



        }
    }
}
