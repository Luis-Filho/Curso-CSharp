using System;
using System.Collections.Generic;
using System.Text;

namespace ImpostosDeRenda.Entities
{
    abstract class Contribuinte
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Contribuinte() { }

        protected Contribuinte(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();

    }
}
