namespace Making_Sense
{
    public class Car
    {
        public int CarID { get; set; }
        public Brand Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public byte Doors { get; set; }
        public Type Type { get; set; }

        public override string ToString()
        {
            return "Car ID:" + CarID + " - Brand: " + this.Brand + " - Model: " + this.Model + " - Color: " + this.Color + " - Doors: " + this.Doors + " - Type: " + this.Type + "\n";
        }

    }
}
