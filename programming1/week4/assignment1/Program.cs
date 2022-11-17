namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int input, count = 0, sum = 0;
            double avg = 0;

            do
            {
                Console.Write("Enter a number: ");
                input = int.Parse(Console.ReadLine());

                if (input > 0)
                {
                    count++;
                    sum += input;
                    avg = (double)sum / (double)count;
                }
            } while (input != 0);

            Console.WriteLine($"Average of all positive numbers is: {avg:0.00}");
        }
    }
}