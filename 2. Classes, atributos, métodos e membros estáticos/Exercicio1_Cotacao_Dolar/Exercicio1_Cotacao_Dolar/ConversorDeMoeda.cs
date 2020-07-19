using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1_Cotacao_Dolar
{
    class ConversorDeMoeda
    {
        public static double converter(double moeda, double qtd)
        {
            double result = moeda * qtd;
            result += (result * 0.06) ;
            return  result;
        }
    }
}
