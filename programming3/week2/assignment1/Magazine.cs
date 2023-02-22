using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class Magazine : Book
    {
        public string date;

        public Magazine(string title, string date, double price)
            : base(title, date, price)
        {
            this.type = Type.Magazine;
            this.date = date;
        }
        public override void PrintBook()
        {
            Console.WriteLine($"[{this.type}] {this.title} - release day:{this.date}, {this.price:0.00}");
        }
    }
}
