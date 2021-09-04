using System;

namespace Making_Sense
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCRUD Cars = new CarCRUD();
            Car Palio = Cars.Create(new Car
            {
                CarID = 0,
                Brand = Brand.FIAT,
                Model = "Palio",
                Color = "Green",
                Doors = 5,
                Type = Type.MANUAL
            });
            Car Fox = Cars.Create( new Car
            {
                CarID = 1,
                Brand = Brand.VOLKSWAGEN,
                Model = "Fox",
                Color = "Grey",
                Doors = 3,
                Type = Type.MANUAL
            });
            Console.WriteLine(Palio.ToString());
            Console.WriteLine(Fox.ToString());
        }
    }
}
