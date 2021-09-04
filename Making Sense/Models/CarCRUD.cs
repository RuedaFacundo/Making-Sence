using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Making_Sense
{
    public class CarCRUD
    {
        private static string _path = @"C:\Users\Acer\source\repos\Making Sense\Making Sense\Cars.json";

        List<Car> cars = new List<Car> ();
        public Car Create(Car car)
        {
            cars.Add(car);
            Save();
            return car;
        }
        //public Car Get(int id)
        //{
        //    string carsJsonFromFile = Read();
        //    var cars = JsonConvert.DeserializeObject<List<Car>>(carsJsonFromFile);

        //    /// terminar funcion, que busque por id
        //}

        public void Save()
        {
            string carsJson = JsonConvert.SerializeObject(cars.ToArray(), Formatting.Indented);
            File.WriteAllText(_path, carsJson);
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
