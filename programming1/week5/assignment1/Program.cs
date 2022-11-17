namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arNumbers = new int[20];
            int sum = 0;

            Random random = new Random();

            for (int i=0;i<arNumbers.Length;i++)
            {
                arNumbers[i] = random.Next(0, 201);
                Console.WriteLine($"Element {i} is {arNumbers[i]}");
                sum += arNumbers[i];
            }

            double avg = (double)sum / arNumbers.Length;
            Console.WriteLine($"\nThe average is: {avg:0.00}\n");

            double dif = 0;
            for (int i = 0; i<arNumbers.Length; i++)
            {
                dif = Math.Abs(avg - arNumbers[i]);
                Console.WriteLine($"Difference between average and element {i} is {dif:0.00}");
            }
        }
    }
}