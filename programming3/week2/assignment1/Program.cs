using System.Globalization;

namespace assignment1
{
    public enum Type
    {
        Book, Magazine
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            BookStore store = new BookStore();
            Book book1 = new Book("Dracula", "Bram Stoker", 15.00);
            store.AddBook(book1);
            Book book2 = new Book("Joe speedboot", "Tommy Wieringa", 12.50);
            store.AddBook(book2);
            Magazine magazine1 = new Magazine("Time", "Friday", 3.90);
            store.AddBook(magazine1);
            Magazine magazine2 = new Magazine("Donald Duck", "Thursday", 2.50);
            store.AddBook(magazine2);
            Book book3 = new Book("The hobbit", "J.R.R. Tolkien", 12.50);
            store.AddBook(book3);
            store.PrintCompleteStock();
        }
    }
}