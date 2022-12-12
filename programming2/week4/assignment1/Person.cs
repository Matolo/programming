using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    public class Person
    { 
        public string Name = "";
        public string City;
        public int Age;

        public Person ReadPerson()
        {
            Person person= new Person();
            Console.Write("Enter your name: ");
            person.Name = Console.ReadLine();
            Console.Write("Enter your city: ");
            person.City = Console.ReadLine();
            Console.Write("Enter your age: ");
            person.Age = int.Parse(Console.ReadLine());

            return person;
        }
        public void DisplayPerson(Person p)
        {
            Console.WriteLine($"Name: {p.Name}");
            Console.WriteLine($"City: {p.City}");
            Console.WriteLine($"Age: {p.Age}");
        }
        public void WritePerson(Person p, string filename)
        {
            StreamWriter writer = new StreamWriter(filename);
            writer.WriteLine(p.Name);
            writer.WriteLine(p.City);
            writer.WriteLine(p.Age);
            writer.Close();
        }
        public Person ReadPerson(string filename)
        {
            Person p = new Person();
            StreamReader reader = new StreamReader(filename);

            p.Name = reader.ReadLine();
            p.City = reader.ReadLine();
            p.Age = int.Parse(reader.ReadLine());
            reader.Close();

            return p;
        }
    }
}
