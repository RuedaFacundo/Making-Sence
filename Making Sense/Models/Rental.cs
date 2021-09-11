using Making_Sense.Models;

namespace Making_Sence.Models
{
    public class Rental
    {
        public string Duration { get; set; }
        public Car car;
        public Customer Client;
        public string DateReturn { get; set; }
        public override string ToString()
        {
            return "Rental \n" + " - Duration: " + Duration + " - Car: " + this.car.ToString() + " - Customer: " + this.Client.ToString() + " - Date Return: " + this.DateReturn + "\n";
        }
    }
}
