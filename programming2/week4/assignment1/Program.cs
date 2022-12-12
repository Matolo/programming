using System.IO;

namespace assignment1
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
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Person person = new Person();

            if (File.Exists("test.txt"))
            {
                person = person.ReadPerson("test.txt");
                if (person.Name.Contains(name))
                {
                    Console.WriteLine($"Nice to see you again, {person.Name}!\nWe have the following information about you:");
                    person.DisplayPerson(person);
                    return;
                }
            }
            Console.WriteLine($"Welcome {name}");
            person.ReadPerson();
            person.WritePerson(person, "test.txt");
            Console.WriteLine("Your data is written to file.");
        }
    }
}