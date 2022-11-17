namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNum = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int thirdNum = int.Parse(Console.ReadLine());

            if(firstNum > thirdNum && secondNum > thirdNum)
            {
                Console.WriteLine("The third number is the smallest of the three");
            }
            else
            {
                Console.WriteLine("The third number is not the smallest of the three");
            }
        }
    }
}