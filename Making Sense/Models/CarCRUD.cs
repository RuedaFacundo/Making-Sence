using Making_Sense.Interface.ICarCrud;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;

namespace Making_Sense.Models
{
    public class CarCRUD : ICRUD<Car>
    {
        private readonly string JsonFile = ConfigurationManager.AppSettings["pathFileCar"];
        public List<Car> carList = new List<Car>();
        public Car Create(Car car)
        {
            carList.Add(car);
            Save();
            return car;
        }
        private void Save()
        {
            string carsJson = JsonConvert.SerializeObject(carList.ToArray(), Formatting.Indented);
            File.WriteAllText(JsonFile, carsJson);
        }
        public Car Get(int id)
        {
            List<Car> Cars = JsonConvert.DeserializeObject<List<Car>>(Read());
            return Cars.Single(car => car.CarID == id);
        }
        private string Read()
        {
            string carsJsonFromFile;
            using (var reader = new StreamReader(JsonFile))
            {
                carsJsonFromFile = reader.ReadToEnd();
            }
            return carsJsonFromFile;
        }
        public Car Update(Car car)
        {
            Car auxCar = Get(car.CarID);
            carList.RemoveAt(auxCar.CarID);
            carList.Add(car);
            Save();
            return car;
        }
        public void Delete(int id)
        {
            try
            {
                carList.Remove(Get(id));
                Save();
                Console.WriteLine("El auto fue eliminado correctamente \n");
            }
            catch (Exception)
            {
                Console.WriteLine("El auto no se pudo eliminar \n");
            }
        }
        public IEnumerable<Car> GetAll()
        {
            List<Car> Cars = JsonConvert.DeserializeObject<List<Car>>(Read());
            return Cars;
        }
    }
}
