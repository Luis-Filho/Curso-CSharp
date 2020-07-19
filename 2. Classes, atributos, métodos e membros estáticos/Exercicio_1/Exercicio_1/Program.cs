using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            p1.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.idade = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            p2.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade) 
            {
                Console.WriteLine(p1.nome + " é mais velha");
            } 
            else
            {
                if (p1.idade < p2.idade)
                {
                    Console.WriteLine(p2.nome + " é mais velha");
                }
                else
                {
                    Console.WriteLine(p1.nome + " e " + p2.nome + " tem as mesmas idades");
                }
            }

        }
    }
}
