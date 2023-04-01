using System.Globalization;

namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        public void Start()
        {
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            Customer customer1 = new Customer("Martin", new DateTime(2001, 10, 09));
            PrintCustomer(customer1);
        }

        public void PrintCustomer (Customer customer)
        {
            Console.WriteLine($"{customer.Name}\ndate of birth: {customer.DateOfBirth:dd/MM/yyyy}\nage: {customer.Age}\ndsicount: {(customer.Discount ? "yes" : "no")}");
        }
    }
}