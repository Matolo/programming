using System;

namespace assignment0
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
            int value = ReadInt("Enter a value: ");
            Console.WriteLine($"You entered {value}");

            int age = ReadInt("How old are you? ", 0, 120);
            Console.WriteLine($"You are {age} years old");

            string name = ReadString("What is your name? ");
            Console.WriteLine($"Nice meeting you {name}.");
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
    }
}