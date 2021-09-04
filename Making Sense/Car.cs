namespace Making_Sense
{
    public class Car
    {
        public int CarID { get; set; }
        public int Model { get; set; }
        public byte Doors { get; set; }
        public string Color { get; set; }
        public Type Type { get; set; }
        public Brand Brand { get; set; }
        public override string ToString()
        {
            return "Car ID:" + CarID + " - Model: " + this.Model + " - Doors: " + this.Doors + " - Color: " + this.Color + " - Type: " + this.Type + " - Brand: " + this.Brand + "\n";
        }

    }
}
