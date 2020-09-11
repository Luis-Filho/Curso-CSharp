using System;
using System.Collections.Generic;
using System.Text;

namespace ImpostosDeRenda.Entities 
{
    class PessoaFisica : Contribuinte
    {
        public double HealthExpenditures { get; set; }

        public PessoaFisica() { }

        public PessoaFisica(string name, double anualIncome, double healthExpenditures) : base (name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double imposto = (AnualIncome < 20000.00) ? 0.15 : 0.25 ;

            return (AnualIncome * imposto) - (HealthExpenditures * 0.5); 
        }
    }
}
