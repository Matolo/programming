namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of seconds: ");
            int secInp = int.Parse(Console.ReadLine());

            int hours = secInp / 3600;
            int minutes = (secInp % 3600) / 60;
            int sec = (secInp % 3600) % 60;

            Console.WriteLine($"{hours:00}:{minutes:00}:{sec:00}");

        }
    }
}