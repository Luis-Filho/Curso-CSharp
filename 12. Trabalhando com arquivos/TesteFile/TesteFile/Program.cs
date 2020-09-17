using System;
using System.IO;

namespace TesteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Luis Costa\Desktop\Cursos\Curso-CSharp\12. Trabalhando com arquivos\teste.txt";
            string targetPath = @"C:\Users\Luis Costa\Desktop\Cursos\Curso-CSharp\12. Trabalhando com arquivos\teste2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
