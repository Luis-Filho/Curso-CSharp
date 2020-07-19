using System;
using System.Globalization;

namespace Exercicio1_Cotacao_Dolar
{
    class Program
    {
        static void Main(string[] args)
        {
            double moeda, valor, resultado;
            
            Console.Write("Qual é a cotação do dólar? ");
            moeda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            resultado = ConversorDeMoeda.converter(moeda, valor);

            Console.WriteLine("Valor a ser pago em reais = " + resultado.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
