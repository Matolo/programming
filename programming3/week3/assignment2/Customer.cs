using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class Customer
    {
        private string _name;
        private DateTime _dateOfBirth;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value == "")
                    throw new ArgumentException("Name cannot be empty");
                _name = value;
            }
        }
        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                if (value >= DateTime.Today)
                {
                    throw new ArgumentException("Date of birth must be in the past!");
                }
                _dateOfBirth = value;
            }
        }
        public int Age
        {
            get
            {
                int age = DateTime.Today.Year - _dateOfBirth.Year;
                if (DateTime.Today < _dateOfBirth.AddYears(age))
                {
                    age--;
                }
                return age;
            }
        }
        public bool Discount { get { return Age > 60; }}
        public Customer(string name, DateTime dateOfBirth)
        {
            this.Name = name;
            this.DateOfBirth = dateOfBirth;
        }
    }
}
