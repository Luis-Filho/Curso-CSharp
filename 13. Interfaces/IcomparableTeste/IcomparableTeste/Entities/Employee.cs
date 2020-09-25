using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace IcomparableTeste.Entities
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name 
                + ", " 
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Employee))
            {
                throw new ArgumentException("Compering error: argument is not employee");
            } 
            else
            {
                Employee other = obj as Employee;
                return Name.CompareTo(other.Name);
            }
        }
    }
}
