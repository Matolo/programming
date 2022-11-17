using System.Globalization;

namespace assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;


            Console.Write("Enter a text> ");
            string text = Console.ReadLine();
            int nrDots, nrCommas, nrSemiColons;

            SearchText(text, out nrDots, out nrCommas, out nrSemiColons);
            Console.WriteLine($"result: {nrDots} full stops, {nrCommas} commas, {nrSemiColons} semicolons");

        }

        static void SearchText(string input, out int nrOfFullStops, out int nrOfCommas, out int nrOfSemiColons)
        {
            nrOfFullStops = 0;
            nrOfCommas = 0;
            nrOfSemiColons = 0;


            for(int i =0; i< input.Length; i++)
            {
                if (input[i] == '.')
                    nrOfFullStops++;
                else if (input[i] == ',')
                    nrOfCommas++;
                else if (input[i] == ';')
                    nrOfSemiColons++;
            }
        }
    }
}