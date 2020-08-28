using System;

namespace Exercicio_Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("How Many rooms will be rented: ");
            int n = int.Parse(Console.ReadLine());
            Estudante[] vect = new Estudante[10];

            for (int i=1; i <= n; i++)
            {
                Console.WriteLine("\n\nRent #" + i.ToString() + ":");
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                vect[room-1] = new Estudante{ Name=name, Email=email};

            }

            Console.WriteLine("\n\nBusy rooms:");
            for (int i=0; i < 10; i++)
            {
                if (vect[i] != null)
                    Console.WriteLine((i + 1).ToString() + ": " + vect[i].Name + ", " + vect[i].Email);
            }
        }
    }
}
