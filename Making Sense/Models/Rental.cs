using Making_Sense.Models;

namespace Making_Sence.Models
{
    public class Rental
    {
        public int RentalId { get; set; }
        public string Duration { get; set; }
        public Car Car { get; set; }
        public Customer Client { get; set; }
        public string DateReturn { get; set; }
        public override string ToString()
        {
            return "Rental \n" + " - Duration: " + Duration + " - Car: " + this.Car.ToString() + " - Customer: " + this.Client.ToString() + " - Date Return: " + this.DateReturn + "\n";
        }
    }
}
