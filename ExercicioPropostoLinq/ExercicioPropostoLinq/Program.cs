using ExercicioPropostoLinq.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ExercicioPropostoLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Luis Costa\Desktop\Cursos\Curso-CSharp\ExercicioPropostoLinq\in.txt";

            List<Product> lista = new List<Product>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    lista.Add(new Product(name, price));
                }
            }

            var avg = lista.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average price = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            var names = lista.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
