using System.Security.Principal;

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
            PrintMonth(Months.January);
        }
        void PrintMonth(Months month)
        {
            Console.WriteLine(month.ToString());
        }
        void PrintMonths()
        {
            for (Months i = Months.January; i < Months.December; i++)
            {
                Console.WriteLine($"{(int)i:00} {i}");
            }
        }
    }
}