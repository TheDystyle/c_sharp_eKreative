using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serializer_json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person("Tom", 37);
            string json = JsonSerializer.Serialize(tom);
            Console.WriteLine(json);
            Person? restoredPerson = JsonSerializer.Deserialize<Person>(json);
            Console.WriteLine(restoredPerson?.Name); // Tom


class Person
        {
            public string Name { get; }
            public int Age { get; set; }
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }
    }
    }
}
