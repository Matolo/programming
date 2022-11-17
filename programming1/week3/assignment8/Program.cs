namespace assignment8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of working hours: ");
            int workingHours = int.Parse(Console.ReadLine());
            Console.Write("Enter number of years: ");
            int numberOfYears = int.Parse(Console.ReadLine());
            Console.Write("Enter number of failures: ");
            int numberOfFailures = int.Parse(Console.ReadLine());

            if (workingHours > 10000 || numberOfYears >= 7 || numberOfFailures > 25)
            {
                Console.WriteLine("\nMachine needs to be replaced.");
            }
            else
            {
                Console.WriteLine("\nMachine does not need to be replaced.");
            }

        }
    }
}