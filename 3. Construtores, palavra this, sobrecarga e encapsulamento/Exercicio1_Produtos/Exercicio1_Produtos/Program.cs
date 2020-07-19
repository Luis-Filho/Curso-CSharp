using System;
using System.Globalization;

namespace Exercicio1_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produtos: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque:");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p1 = new Produto(nome, preco, quantidade);
            Produto p2 = new Produto();
            Produto p3 = new Produto {
                Nome = "TV",
                Preco = 500.00,
                Quantidade = 10
            };

            Console.WriteLine("Dados do produto: " + p1);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado: ");
            int qte = int.Parse(Console.ReadLine());
            p1.AdicionarProdutos(qte);

            Console.WriteLine();

            Console.WriteLine("Dados Atualizados: ");
            Console.WriteLine("Dados do produto: " + p1);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removidos: ");
            qte = int.Parse(Console.ReadLine());
            p1.RemoverProdutos(qte);

            Console.WriteLine();

            Console.WriteLine("Dados Atualizados: ");
            Console.WriteLine("Dados do produto: " + p1);
        }
    }
}
