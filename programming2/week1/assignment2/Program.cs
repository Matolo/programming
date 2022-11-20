using System;

namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            Person[] people = new Person[3];

            for (int i = 0; i<3; i++)
            {
                people[i] = ReadPerson();
                Console.WriteLine();
            }
            for (int i = 0; i<3; i++)
            {
                PrintPerson(people[i]);
            }
        }
        int ReadInt(string question)
        {
            Console.Write(question);
            int input = int.Parse(Console.ReadLine());
            return input;
        }
        int ReadInt(string question, int min, int max)
        {
            int input = ReadInt(question);
            while (input < min || input > max)
                input = ReadInt(question);

            return input;
        }
        string ReadString(string question)
        {
            Console.Write(question);
            string name = Console.ReadLine();
            return name;
        }
        GenderType ReadGender(string question)
        {
            Console.Write(question);
            string input = Console.ReadLine();

            switch (input)
            {
                case "f":
                    return GenderType.Female;
                    break;
                default:
                    return GenderType.Male;
                    break;

            }
        }
        Person ReadPerson()
        {
            Person person = new Person();

            person.FirstName = ReadString("Enter first name: ");
            person.LastName = ReadString("Enter last name: ");
            person.Gender = ReadGender("Enter gender (m/f): ");
            person.Age = ReadInt("Enter age: ");
            person.City = ReadString("Enter city: ");

            return person;
        }
        void PrintPerson(Person p)
        {
            Console.WriteLine();
            Console.Write(p.FirstName + " " + p.LastName);
            PrintGender(p.Gender);
            Console.WriteLine($"\n{p.Age} years old, {p.City}");
        }
        void PrintGender(GenderType gender)
        {
            switch (gender)
            {
                case GenderType.Female:
                    Console.Write("(f)");
                    break;
                case GenderType.Male:
                    Console.Write("(m)");
                    break;
            }
        }
    }
}