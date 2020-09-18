using System;
using System.IO;

namespace UsingBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Luis Costa\Desktop\Cursos\Curso-CSharp\12. Trabalhando com arquivos\teste.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }
    }
}
