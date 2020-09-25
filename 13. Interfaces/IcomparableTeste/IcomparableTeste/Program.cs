using IcomparableTeste.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace IcomparableTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Luis Costa\Desktop\Cursos\Curso-CSharp\13. Interfaces\in.csv";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            } 
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
