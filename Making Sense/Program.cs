using Making_Sence.Controllers;
using Making_Sence.Models;
using Making_Sense.Controllers;
using Making_Sense.Models;
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
            Car Fox = Cars.Create(new Car
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
            CustomerCRUD customers = new CustomerCRUD();
            var facundo = customers.Create(new Customer
            {
                customerID = 0,
                DNI = 36617481,
                Name = "Facundo",
                Surname = "Rueda",
                Telephone = "2235378667",
                Adress = "Friuli 797",
                City = "Mar del Plata",
                State = "Buenos Aires",
                ZipCode = 7600
            });
            try
            {
                Console.WriteLine(customers.Get(0).ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("El cliente no se encuentra, ingrese el ID correcto");
            }
            var hernan = new Customer
            {
                customerID = 1,
                DNI = 36844955,
                Name = "Hernan",
                Surname = "Pino",
                Telephone = "2235389556",
                Adress = "Gascon 1060",
                City = "Mar del Plata",
                State = "Buenos Aires",
                ZipCode = 7600
            };
            try
            {
                Console.WriteLine(customers.Update(hernan).ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("No se pudo actualizar el cliente correctamente");
            }
            var chapu = customers.Create(new Customer
            {
                customerID = 3,
                DNI = 34566029,
                Name = "chapu",
                Surname = "villaverde",
                Telephone = "2235378667",
                Adress = "Friuli 797",
                City = "Mar del Plata",
                State = "Buenos Aires",
                ZipCode = 7600
            });
            var hugo = customers.Create(new Customer
            {
                customerID = 4,
                DNI = 34566029,
                Name = "hugo",
                Surname = "moreno",
                Telephone = "2235378667",
                Adress = "Friuli 797",
                City = "Mar del Plata",
                State = "Buenos Aires",
                ZipCode = 7600
            });
            RentalCRUD rentals = new RentalCRUD();
            var Rental = rentals.Create(new Rental
            {
                RentalId = 1,
                Duration = "7 days",
                Car = Corsa,
                Client = facundo,
                DateReturn = "15/10/2021"
            });
            Console.WriteLine(rentals.Get(1).ToString());
            var RentalHernan = rentals.Create(new Rental
            {
                RentalId = 2,
                Duration = "14 days",
                Car = Corsa,
                Client = hernan,
                DateReturn = "15/12/2021"
            });
            rentals.Delete(1);
            try
            {
                Console.WriteLine(rentals.Update(RentalHernan).ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("No se pudo actualizar la renta correctamente");
            }
            /*foreach (Car car in Cars.GetAll())
            {
                Console.WriteLine(car.ToString());
            }
            foreach (Customer customer in customers.GetAll())
            {
                Console.WriteLine(customer.ToString());
            }*/
        }
    }
}