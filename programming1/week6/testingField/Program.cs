using System.Globalization;

namespace testingField
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;



            string[] words = new string[20];

            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            int numberOfWords = 0;
            while (word.Length > 0 && numberOfWords < 20)
            {
                words[numberOfWords] = word;
                numberOfWords++;

                Console.Write("Enter a word: ");
                word = Console.ReadLine();

            }
            for (int i = 0; i <numberOfWords;i++)
            {
                if (words[i].Length % 2 == 0)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine(words[i]);
            }

            Console.ResetColor();


        }
    }
}