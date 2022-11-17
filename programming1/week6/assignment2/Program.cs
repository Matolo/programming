using System.Globalization;

namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;


            Console.Write("Enter number (0 is stop value): ");
            int input = int.Parse(Console.ReadLine());

            while (input != 0)
            {
                if (input < 0)
                {
                    Console.WriteLine("Negative number entered...");
                }
                else
                {
                    if (IsPrimeNumber(input))
                    {
                        Console.WriteLine($"{input} is a prime number.");
                    }
                    else
                    {
                        Console.WriteLine($"{input} is not a prime number.");
                    }
                }
                Console.Write("Enter number (0 is stop value): ");
                input = int.Parse(Console.ReadLine());
            }
                Console.WriteLine("end of program");
        }


        static bool IsPrimeNumber(int input)
        {
            bool isPrime = true;
            int i = 2;
            while (i < input && isPrime)
            {
                if (input % i == 0)
                {
                    isPrime = false;
                    
                }
                else
                    i++;
            }
            return isPrime;
        }
    }
}