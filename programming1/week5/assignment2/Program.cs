namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arNumbers = new int[20];
            Random rand = new Random();

            for (int i = 0; i<arNumbers.Length; i++)
            {
                arNumbers[i] = rand.Next(0, 150);
                Console.WriteLine($"Element {i} = {arNumbers[i]}");
            }

            int smlNum = arNumbers[0];
            for (int i = 1; i<arNumbers.Length;i++)
                if (smlNum > arNumbers[i])
                    smlNum = arNumbers[i];
            

            int counter = 0;
            for (int i = 0; i<arNumbers.Length; i++)
                if(smlNum == arNumbers[i])
                    counter++;    
            

            Console.WriteLine($"smallest number = {smlNum}");
            Console.WriteLine($"number of occurence = {counter}");
        }
    }
}