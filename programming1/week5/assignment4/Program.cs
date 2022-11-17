namespace assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];

            Console.Write("Enter a number (0=stop): ");
            int input = int.Parse(Console.ReadLine());

            int index = 0;
            while (input != 0)
            {
                if (index < numbers.Length)
                {
                    numbers[index] = input;
                    index++;
                }
                
                Console.Write("Enter a number (0=stop): ");
                input = int.Parse(Console.ReadLine());

            }

            Console.WriteLine();
            Console.Write("Enter a searchvalue: ");
            input = int.Parse(Console.ReadLine());

             
            int counter = 0;
            for (int j = 0; j < index; j++)
            {
                if (numbers[j] == input)
                    counter++;
            }
            Console.WriteLine($"\nNumber of occurences of searchvalue ({input}) is: {counter}");
        }
    }
}