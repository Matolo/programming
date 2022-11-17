namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int input, count = 0, sum =0;


            do
            {
                Console.Write("Enter a number: ");
                input = int.Parse(Console.ReadLine());           
                count++;
                if (count % 5 == 0)
                {
                    sum += input;
                }
                                
            } while (input != 0);

            Console.WriteLine($"Sum of 5th, 10th, 15th, ... number is: {sum}");
        }
    }
}