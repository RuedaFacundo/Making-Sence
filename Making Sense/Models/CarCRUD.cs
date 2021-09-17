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
        public List<Car> Cars = new List<Car>();
        public Car Create(Car car)
        {
            Cars.Add(car);
            Save();
            return car;
        }
        private void Save()
        {
            string carsJson = JsonConvert.SerializeObject(Cars.ToArray(), Formatting.Indented);
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
        public Car Update (Car car)
        {
            Car aux = Get(car.CarID);
            Cars.RemoveAt(aux.CarID);
            Cars.Add(car);
            Save();
            return car;
        }
        public void Delete (int id)
        {
            int index = Cars.FindIndex(i => i.CarID == id);
            if (index >= 0)
            {
                Cars.RemoveAt(index);
                Save();
            } else
            {
                Console.WriteLine("El auto a eliminar no fue encontrado");
            }          
        }
    }
}
