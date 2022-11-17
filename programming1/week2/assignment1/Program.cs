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


            double price =0f, total, vat;
            const float vatRate = 0.21f;

            Console.Write("Enter a price: ");
            price = double.Parse(Console.ReadLine());

            vat = price * vatRate;
            total = price + vat;

            Console.WriteLine($"price: {price:0.00}, VAT: {vat:0.00}, total: {total:0.00}");
        }
    }
}