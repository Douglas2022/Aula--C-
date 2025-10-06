using System;

namespace ConsoleApp1.Entities
{
    internal class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vericle Vericle { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vericle vericle)
        {
            Start = start;
            Finish = finish;
            Vericle = vericle;
            Invoice = null;
        }
    }
}
