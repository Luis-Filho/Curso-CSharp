using System;
using System.IO;

namespace StringWriteTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Luis Costa\Desktop\Cursos\Curso-CSharp\12. Trabalhando com arquivos\teste.txt";
            string targetPath = @"C:\Users\Luis Costa\Desktop\Cursos\Curso-CSharp\12. Trabalhando com arquivos\teste2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath)) 
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
                throw;
            }
            
        }
    }
}
