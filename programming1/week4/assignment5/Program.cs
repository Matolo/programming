namespace assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int input;

            do
            {
                Console.Write("Enter a year: ");
                input = int.Parse(Console.ReadLine());

                if (input == 0)
                    break;

                if ((input % 400) == 0 || ((input % 4) == 0 && (input % 100) != 0))
                {
                    Console.WriteLine($"{input} is a leap year.");
                }
                else if (input < 0)
                {
                    Console.WriteLine("Year must be positive!");
                }
                else
                {
                    Console.WriteLine($"{input} is not a leap year.");
                }
            } while (input != 0);
        }
    }
}