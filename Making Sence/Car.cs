namespace Making_Sence
{
    public class Car : Vehicle
    {
        private int carID = 0;
        public string model;
        public byte doors;
        public string color;
        public Type type;

        public Car(string model, byte doors, string color, Type type)
        {
            this.model = model;
            this.doors = doors;
            this.color = color;
            this.type = type;
            carID = FakeID++;
        }

        public override string ToString()
        {
            return "Car ID:" + carID + " - Model: " + this.model + " - Doors: " + this.doors + " - Color: " + this.color + " - Type: " + this.type + "\n";
        }

    }
}
