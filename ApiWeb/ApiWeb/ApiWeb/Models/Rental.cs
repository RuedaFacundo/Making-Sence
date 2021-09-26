using System;

namespace ApiWeb.Models
{
    public class Rental
    {
        public long RentalId { get; set; }
        public string Duration { get; set; }
        public Car Car { get; set; }
        public Customer Client { get; set; }
        public DateTime DateReturn { get; set; }
    }
}