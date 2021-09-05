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
            Car Megane = Cars.Create(new Car
            {
                CarID = 2,
                Brand = Brand.RENAULT,
                Model = "Megane",
                Color = "Black",
                Doors = 5,
                Type = Type.AUTOMATIC
            });
            Console.WriteLine(Palio.ToString());
            Console.WriteLine(Fox.ToString());
            Console.WriteLine(Megane.ToString());
            Console.WriteLine(Cars.Get(0).ToString());
            Console.WriteLine(Cars.Get(2).ToString());
            Car Corsa = new Car
            {
                CarID = 1,
                Brand = Brand.CHEVROLET,
                Model = "Corsa",
                Color = "Blue",
                Doors = 5,
                Type = Type.MANUAL
            };
            Console.WriteLine("El auto actualizado: ");
            Console.WriteLine(Cars.Update(Corsa).ToString());
            Cars.Delete(1);

        }
    }
}
