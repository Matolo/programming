using System.Globalization;

namespace testingField
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a initial capital: ");
            int initialCapital = int.Parse(Console.ReadLine());


            double newVariable = (double)initialCapital;
            for (int i = 1; i<=5;i++)
            {
                newVariable = newVariable * 1.05;
            }
            Console.WriteLine($"Capital after 5 years: {newVariable:0.00}");
        }
    }
}