using System.Runtime.Intrinsics.X86;

namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, count = 0;

            Console.Write("Enter target number: ");
            int targetNumber = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Enter a number: ");
                input = int.Parse(Console.ReadLine());

                if (input == targetNumber)
                {
                    count++;
                }
            } while (input != 0);

            Console.WriteLine($"Count of numbers equal to target number: {count}");

        }
    }
}