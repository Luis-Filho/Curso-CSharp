using System;
using System.Globalization;

namespace Exercicio1_conta_bancaria
{
    class Program
    {
        static void Main(string[] args)
        {

            double valor;
            ContaBancaria c;

            Console.Write("Entre o número da conta: ");
            int numero_conta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char flag = char.Parse(Console.ReadLine());

            if (flag == 's' || flag == 'S')
            {
                Console.Write("Entre o valor de depósito: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new ContaBancaria(numero_conta, nome, valor);
            } 
            else
            {
                c = new ContaBancaria(numero_conta, nome);
            }

            Console.WriteLine(c);

            Console.Write("Entre um valor para depósito: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(valor);
            Console.WriteLine(c);

            Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(valor);
            Console.WriteLine(c);
        }
    }
}
