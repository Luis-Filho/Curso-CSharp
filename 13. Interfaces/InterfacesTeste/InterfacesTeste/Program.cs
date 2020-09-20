using InterfacesTeste.Entities;
using InterfacesTeste.Services;
using System;
using System.Globalization;

namespace InterfacesTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter retal data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:ss): ");
            DateTime start = DateTime.ParseExact(
                Console.ReadLine(), 
                "dd/MM/yyyy HH:mm", 
                CultureInfo.InvariantCulture
            );

            Console.Write("Return (dd/MM/yyyy hh:ss): ");
            DateTime finish = DateTime.ParseExact(
                Console.ReadLine(),
                "dd/MM/yyyy HH:mm",
                CultureInfo.InvariantCulture
            );

            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("\n\n\nINVOICE: ");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
