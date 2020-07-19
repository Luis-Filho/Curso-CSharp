using System;
using System.Globalization;

namespace Exercicio_aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();

            Console.Write("Nome do aluno: ");
            a1.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            a1.Notas[0] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a1.Notas[1] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a1.Notas[2] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = a1.SomaNotas();

            Console.WriteLine("NOTA FINAL " + total.ToString("F2", CultureInfo.InvariantCulture));

            if (total >= 60)
            {
                Console.WriteLine("APROVADO");
            } 
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + (60 - total).ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
