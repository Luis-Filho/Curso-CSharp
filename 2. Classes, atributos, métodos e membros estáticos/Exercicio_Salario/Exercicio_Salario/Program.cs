using System;
using System.Globalization;

namespace Exercicio_Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            Console.WriteLine("Entre com as informações do funcionário: ");
            
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            
            Console.Write("Salário Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + f);

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double pct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            f.AumentarSalario(pct);
            Console.WriteLine("Dados Atualizados: " + f);



        }
    }
}
