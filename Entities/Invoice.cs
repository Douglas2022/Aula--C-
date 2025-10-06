using System.Globalization;

namespace ConsoleApp1.Entities
{
    internal class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPaiment, double tax)
        {
            BasicPayment = basicPaiment;
            Tax = tax;
        }
        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }
        public override string ToString()
        {
            return "Basic Payment: "
                + BasicPayment.ToString("F2",CultureInfo.InvariantCulture)
                + "/Taxi"
                + Tax.ToString("F2",CultureInfo.InvariantCulture)
                + "/TotalPayment:"
                + TotalPayment.ToString("F2",CultureInfo.InvariantCulture);


        }
    }
}
