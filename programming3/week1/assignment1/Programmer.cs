using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class Programmer
    {
        public string name;
        public Speciality speciality;

        public Programmer(string name)
        {
            this.name = name;
            this.speciality = Speciality.Unknown;
        }
        public Programmer(string name, Speciality speciality ) 
            :this(name)
        { 
            this.speciality = speciality;
        }
       
        public void Print()
        {
            Console.WriteLine($"Name: {this.name}, Speciality:  {this.speciality}");
        }
    }
}
