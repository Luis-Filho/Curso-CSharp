using System;
using System.IO;


namespace FileStreamTeste
{
    
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Luis Costa\Desktop\Cursos\Curso-CSharp\12. Trabalhando com arquivos\teste.txt";
            
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    Console.WriteLine(line);
                }

                
            }
            catch (IOException e)
            {
                Console.WriteLine("An error accured");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                
            }
        }
    }
}
