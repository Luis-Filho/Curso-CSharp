using InterfaceExercicio.Entities;
using InterfaceExercicio.Services;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace InterfaceExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter number of Installment: ");
            int months = int.Parse(Console.ReadLine());

            Contract myContract = new Contract(contractNumber, contractDate, contractValue);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(myContract, months);

            Console.WriteLine("\nInstallments: ");
            foreach (Installment installment in myContract.Installments) 
            {
                Console.WriteLine(installment);
            }
        }
    }
}
