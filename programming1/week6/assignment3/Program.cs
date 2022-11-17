using System.Globalization;

namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;


            Console.Write("Enter year (0 is stop value): ");
            int year = int.Parse(Console.ReadLine());

            while (year != 0)
            {
                if (year < 0)
                    Console.WriteLine("Negative year entered...");
                else
                {
                    if (IsLeapYear(year))
                        Console.WriteLine($"{year} is a leap year.");
                    else
                        Console.WriteLine($"{year} is not a leap year.");
                }
                Console.Write("Enter year (0 is stop value): ");
                year = int.Parse(Console.ReadLine());
            }
            
                Console.WriteLine("end of program");
        }

        static bool IsLeapYear(int input)
        {
            if ((input % 400) == 0 || ((input % 4) == 0 && (input % 100) != 0))
                return true;
            else
                return false;
        }
    }
}