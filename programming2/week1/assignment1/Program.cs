using System;

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
            PrintMonths();
            PrintMonth(ReadMonth("Enter a month number: "));
        }
        void PrintMonth(Month month)
        {
            Console.WriteLine(month);
        }
        void PrintMonths()
        {
            for (Month i = Month.January; i <= Month.December; i++)
            {
                Console.Write($"{(int)i}. ");
                PrintMonth(i);
            }
        }
        Month ReadMonth(string question)
        {
            Console.WriteLine();
            Console.Write(question);

            int input = int.Parse(Console.ReadLine());
            Month month = (Month)input;

            while (!(Enum.IsDefined(typeof(Month), month)))
            {
                Console.WriteLine($"{input} is not a valid value.");
                Console.Write(question);
                input = int.Parse(Console.ReadLine());
                month = (Month)input;
            }
            Console.Write($"{(int)month} => ");
            return month;
        }
    }
}