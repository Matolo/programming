namespace assignment4
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

            double hiNum, lowNum, sum, avg, prd;

            if (firstNum >= secondNum && firstNum >= thirdNum)
            {
                hiNum = firstNum;
                if (secondNum > thirdNum)
                {
                    lowNum = thirdNum;
                }
                else
                {
                    lowNum = secondNum;
                }
            }
            else if (secondNum >= firstNum && secondNum >= thirdNum)
            {
                hiNum = secondNum;
                if (firstNum > thirdNum)
                {
                    lowNum = thirdNum;
                }
                else
                {
                    lowNum = firstNum;
                }
            }
            else
            {
                hiNum = thirdNum;
                if (firstNum > secondNum)
                {
                    lowNum = secondNum;
                }
                else
                {
                    lowNum = firstNum;
                }
            }

            sum = firstNum + secondNum + thirdNum;
            avg = sum / 3;
            prd = firstNum * secondNum * thirdNum;

            Console.WriteLine($"sum = {sum}");
            Console.WriteLine($"average = {avg:0.00}");
            Console.WriteLine($"product = {prd}");
            Console.WriteLine($"highest = {hiNum}");
            Console.WriteLine($"lowest = {lowNum}");

        }
    }
}