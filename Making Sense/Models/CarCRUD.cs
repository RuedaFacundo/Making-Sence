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
        public Car Get(int id)
        {
            List<Car> CarList = JsonConvert.DeserializeObject<List<Car>>(Read());
            Car aux = new Car();
            foreach (var car in CarList)
            {
                if(car.CarID == id)
                {
                    aux = car;
                }
            }
            return aux;
        }
        public string Read()
        {
            string carsJsonFromFile;
            using (var reader = new StreamReader(_path))
            {
                carsJsonFromFile = reader.ReadToEnd();
            }
            return carsJsonFromFile;
        }
    }
}
