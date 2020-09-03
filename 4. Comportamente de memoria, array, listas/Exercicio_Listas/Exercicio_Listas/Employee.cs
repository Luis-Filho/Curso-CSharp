using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio_Listas
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee()
        {

        }

        public Employee(int id, string nome, double salary)
        {
            Id = id;
            Name = Name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * percentage / 100.0;
        }


        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
