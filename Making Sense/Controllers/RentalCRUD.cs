using Making_Sence.Models;
using Making_Sense.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;

namespace Making_Sense.Controllers
{
    public class RentalCRUD : ICRUD<Rental>
    {
        private readonly string JsonFile = ConfigurationManager.AppSettings["pathFileRental"];
        public List<Rental> rentalList = new List<Rental>();
        public Rental Create(Rental rental)
        {
            rentalList.Add(rental);
            Save();
            return rental;
        }
        private void Save()
        {
            string rentalJson = JsonConvert.SerializeObject(rentalList.ToArray(), Formatting.Indented);
            File.WriteAllText(JsonFile, rentalJson);
        }
        public Rental Get(int id)
        {
            List<Rental> Rentals = JsonConvert.DeserializeObject<List<Rental>>(Read());
            return Rentals.Single(rental => rental.RentalId == id);
        }
        private string Read()
        {
            string rentalJsonFromFile;
            using (var reader = new StreamReader(JsonFile))
            {
                rentalJsonFromFile = reader.ReadToEnd();
            }
            return rentalJsonFromFile;
        }
        public Rental Update(Rental rental)
        {
            Rental auxRental = Get(rental.RentalId);
            rentalList.RemoveAt(auxRental.RentalId);
            rentalList.Add(rental);
            Save();
            return rental;
        }
        public void Delete(int id)
        {
            try
            {
                rentalList.Remove(Get(id));
                Save();
                Console.WriteLine("La reserva fue eliminada correctamente \n");
            }
            catch (Exception)
            {
                Console.WriteLine("No se pudo cancelar la reserva \n");
            }
        }
        public IEnumerable<Rental> GetAll()
        {
            List<Rental> rentals = JsonConvert.DeserializeObject<List<Rental>>(Read());
            return rentals;
        }
    }
}