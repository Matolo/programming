namespace assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNum = int.Parse(Console.ReadLine());

            

            if ((firstNum % secondNum) == 0)
            {
                Console.WriteLine("Number 1 is multiple of number 2");
            }
            else if ((secondNum  % firstNum) == 0)
            {
                Console.WriteLine("Number 2 is multiple of number 1");

            }
            else
            {
                Console.WriteLine("Numbers are no multiples");
            }
        }
    }
}