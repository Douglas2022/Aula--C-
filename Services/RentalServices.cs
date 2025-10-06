using System;
using ConsoleApp1.Entities;
namespace ConsoleApp1.Services
{
    internal class RentalServices
    {
        public double PricePerHour { get;private set; }
        public double PricePerDay { get; private set; }

        private BrazilTaxService _barzilTaxService = new BrazilTaxService();

        public RentalServices(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }
        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
           
            double basicPayment = 0.0;
            if(duration.TotalHours <= 12.0){
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _barzilTaxService.Tax(basicPayment);
            carRental.Invoice = new Invoice(basicPayment, tax);


        }
    }
}
