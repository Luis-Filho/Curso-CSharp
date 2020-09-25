using System;
using System.Collections.Generic;

namespace ExercicioPropostoSetGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> a = new HashSet<int>();
            HashSet<int> b = new HashSet<int>();
            HashSet<int> c = new HashSet<int>();
            HashSet<int> all = new HashSet<int>();
            
            
            Console.Write("How many students for course A: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)            
                a.Add(int.Parse(Console.ReadLine()));

            Console.Write("How many students for course B: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
                b.Add(int.Parse(Console.ReadLine()));

            Console.Write("How many students for course c: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
                c.Add(int.Parse(Console.ReadLine()));

            all.UnionWith(a);
            all.UnionWith(b);
            all.UnionWith(c);

            Console.WriteLine("Total students: " + all.Count);


        }
    }
}
