using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Making_Sense
{
    public class CarCRUD
    {
        private static string _path = @"C:\Users\Acer\source\repos\Making Sense\Making Sense\Cars.json";
        public List<Car> Cars = new List<Car>();
        public Car Create(Car car)
        {
            Cars.Add(car);
            Save();
            return car;
        }
        public void Save()
        {
            string carsJson = JsonConvert.SerializeObject(Cars.ToArray(), Formatting.Indented);
            File.WriteAllText(_path, carsJson);
        }
    }
}
