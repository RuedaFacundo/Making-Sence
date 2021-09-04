using System;

namespace Making_Sense
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Palio = new Car
            {
                CarID = 0,
                Brand = Brand.FIAT,
                Color = "green",
                Doors = 5,
                Model = "Palio",
                Type = Type.MANUAL
            };
            Car Fox = new Car
            {
                CarID = 1,
                Brand = Brand.VOLKSWAGEN,
                Color = "grey",
                Doors = 3,
                Model = "Fox",
                Type = Type.MANUAL
            };
            Console.WriteLine(Palio.ToString());
            Console.WriteLine(Fox.ToString());
        }
    }
}
