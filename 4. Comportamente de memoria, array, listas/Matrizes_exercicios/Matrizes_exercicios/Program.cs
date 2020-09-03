using System;
using System.Runtime.ConstrainedExecution;

namespace Matrizes_exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);

            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j] == x)
                    {
                        Console.WriteLine("Position: " + i + ", " + j);
                        if (i - 1 >= 0) Console.WriteLine("UP: " + mat[i - 1, j]);
                        if (i + 1 < m) Console.WriteLine("DOWN: " + mat[i + 1, j]);
                        if (j - 1 >= 0) Console.WriteLine("LEFT: " + mat[i, j-1]);
                        if (j + 1 < n) Console.WriteLine("RIGHT: " + mat[i, j + 1]);
                    }
                }
            }
        }

        
    }
}
