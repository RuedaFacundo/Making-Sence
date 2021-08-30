using System;

namespace Making_Sense
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Fiat = new Car("Palio", 5, "red", Type.MANUAL);
            Car Ford = new Car("Fiesta", 5, "black", Type.AUTOMATIC);
            Car Chevrolet = new Car("Corsa", 3, "blue", Type.MANUAL);
            Car Peugeot = new Car("308", 5, "red", Type.AUTOMATIC);
            Car Renault = new Car("Sandero", 5, "green", Type.AUTOMATIC);
            Car Volkswagen = new Car("Fox", 3, "grey", Type.MANUAL);

            Console.WriteLine(Fiat.ToString());
            Console.WriteLine(Ford.ToString());
            Console.WriteLine(Chevrolet.ToString());
            Console.WriteLine(Peugeot.ToString());
            Console.WriteLine(Renault.ToString());
            Console.WriteLine(Volkswagen.ToString());

        }
    }
}
