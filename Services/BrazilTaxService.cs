
namespace ConsoleApp1.Services
{
    internal class BrazilTaxService
    {
        public double Tax(double amout)
        {
            if (amout <= 100)
            {
                return amout * 0.2;
            }
            else
            {
                return amout * 0.15;
            }

        }
    }
}
