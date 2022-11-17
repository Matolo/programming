using System.Globalization;

namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;


            Console.Write("Enter a price: ");
            float price = float.Parse(Console.ReadLine());

            float total = price + CalculateVat(price);
            Console.WriteLine($"price: {price:0.00}, VAT: {CalculateVat(price):0.00}, total: {total:0.00}");


        }

        static float CalculateVat(float price)
        {
            return price * 0.21f;
        }
    }
}