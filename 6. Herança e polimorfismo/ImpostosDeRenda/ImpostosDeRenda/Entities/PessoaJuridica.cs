using System;
using System.Collections.Generic;
using System.Text;

namespace ImpostosDeRenda.Entities
{
    class PessoaJuridica : Contribuinte
    {
        public int NumberOfEmployees { get; set; }

        public PessoaJuridica() { }

        public PessoaJuridica(string name, double anualIncome, int numberOfEmployees) : base (name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double imposto = (NumberOfEmployees > 10) ? 0.14 : 0.16;

            return AnualIncome * imposto;
        }
    }
}
