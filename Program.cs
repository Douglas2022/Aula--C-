using System;
using System.Globalization;
using ConsoleApp1.Entities;
using ConsoleApp1.Services;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entel rental data");
            Console.WriteLine("Car model:");
            string model = Console.ReadLine();
            Console.WriteLine("Pickup: dd/MM/yyyy hh:ss");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Return dd/MM/yyyy hh:ss");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start,finish,new Vericle(model));

            RentalServices rentalServices = new RentalServices(hour,day);

            rentalServices.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);


        }
    }
}
