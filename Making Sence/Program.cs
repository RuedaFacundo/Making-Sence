using System;

namespace Making_Sence
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Fiat = new Car() { model = "Palio", doors = 5, color = "red", type = Type.MANUAL };
            Car Ford = new Car() { model = "Fiesta", doors = 5, color = "black", type = Type.AUTOMATIC };
            Car Chevrolet = new Car() { model = "Corsa", doors = 3, color = "blue", type = Type.MANUAL };
            Car Peugeot = new Car() { model = "308", doors = 5, color = "red", type = Type.AUTOMATIC };
            Car Renault = new Car() { model = "Sandero", doors = 5, color = "green", type = Type.AUTOMATIC };
            Car Volkswagen = new Car() { model = "Fox", doors = 3, color = "grey", type = Type.MANUAL };

        }
    }
}
