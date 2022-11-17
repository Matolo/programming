namespace assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int firstEl = 1;
            int secondEl = 1;

            for (int i = 0; i < 20; i++)
            {

                if (i != 19)
                {
                    int thirdEl = firstEl + secondEl;
                    Console.Write($"{firstEl}, ");
                    firstEl = secondEl;
                    secondEl = thirdEl;
                }
                else
                {
                    Console.Write(firstEl);
                }

            }

        }
    }

}