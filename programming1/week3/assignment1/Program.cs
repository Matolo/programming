namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNum = int.Parse(Console.ReadLine());

            int hiNum, lwNum;
            if(secondNum<firstNum)
            {
                hiNum = firstNum;
                lwNum = secondNum;
            } 
            else
            {
                hiNum = secondNum;
                lwNum = firstNum;
            }
            Console.WriteLine($"highest value is: {hiNum}");
            Console.WriteLine($"lowest value is: {lwNum}");
        }
    }
}