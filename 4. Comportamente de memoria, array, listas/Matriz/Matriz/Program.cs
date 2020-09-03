using System;
using System.Net.Http.Headers;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]); 
                }
            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine("");
            }

            Console.Write("valores da diagonal: ");
            for (int i = 0; i < n; i++)
                Console.Write(mat[i, i] + " ");

            Console.WriteLine("");
            int negatives = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                        negatives++;
                }
            }

            Console.WriteLine("Quantidde de valores negativos: " + negatives);





        }
    }
}
