using System;
using System.Globalization;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double soma = 0;
            double avg;

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            for (int i = 0; i < n; i++)
                soma += vect[i];

            avg = soma / n;

            Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
