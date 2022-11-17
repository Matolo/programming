namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1st number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter 3rd number: ");
            double thirdNumber = double.Parse(Console.ReadLine());

            double avgNum = (firstNumber + secondNumber + thirdNumber) / 3;

            Console.WriteLine($"The average is: {avgNum}");

            /* string input;

             Console.Write("Enter 1st number: ");
             input = Console.ReadLine();
             double firstNumber = double.Parse(input);

             Console.Write("Enter 2nd number: ");
             input = Console.ReadLine();
             double secondNumber = double.Parse(input);

             Console.Write("Enter 1st number: ");
             input = Console.ReadLine();
             double thirdNumber = double.Parse(input);

             double avgNum = (firstNumber + secondNumber + thirdNumber) / 3;

             Console.WriteLine($"The average is: {avgNum}");*/

        }
    }
}