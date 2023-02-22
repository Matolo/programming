using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class Book
    {
        public string title, author;
        public double price;
        public Type type;



        public Book(string title, string author, double price)
        {
            this.type = Type.Book;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public virtual void PrintBook()
        {
            Console.WriteLine($"[{this.type}] '{this.title}' by {this.author}, {this.price:0.00}");
        }
    }
}
