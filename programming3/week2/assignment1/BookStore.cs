using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class BookStore
    {
        List<Book> books = new List<Book>();
        public double totalPrice;

        public void AddBook(Book book)
        {
            this.books.Add(book);
            this.totalPrice += book.price;
        }
        public void PrintCompleteStock()
        {
            foreach (Book book in this.books)
            {
                book.PrintBook();
            }
            Console.WriteLine($"\nTotal sales price: {this.totalPrice:0.00}");
        }
    }
}
