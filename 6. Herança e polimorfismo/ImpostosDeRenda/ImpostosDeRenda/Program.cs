using ImpostosDeRenda.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ImpostosDeRenda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuinte> list = new List<Contribuinte>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax payer {i+1} data:");
                Console.Write("Individual or company (i/c): " );
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditure = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new PessoaFisica(name, anualIncome, healthExpenditure));
                }
                else
                {
                    Console.Write("Number of Employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    list.Add(new PessoaJuridica(name, anualIncome, numberOfEmployees));
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("\nTAXES PAID");
            double taxes = 0.0;
            foreach (Contribuinte c in list)
            {
                Console.WriteLine(c.Name + ": $ " + c.Tax().ToString("F2", CultureInfo.InvariantCulture));
                taxes += c.Tax();
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + taxes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
