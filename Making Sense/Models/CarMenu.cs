using Making_Sense.Models;
using System;

namespace Making_Sence.Models
{
    public class CarMenu
    {
        public void Menu()
        {
            CarCRUD carsCrud = new CarCRUD();
            Console.Clear();
            Console.WriteLine("Seleccione una opcion: \n");
            Console.WriteLine(" 1 - Crear un auto \n");
            Console.WriteLine(" 2 - Modificar un auto \n");
            Console.WriteLine(" 3 - Buscar un auto \n");
            Console.WriteLine(" 4 - Eliminar un auto \n");
            Console.WriteLine(" 5 - Listar autos \n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    var newCar = new Car();
                    Console.WriteLine("Ingrese la marca del auto: \n");
                    Console.WriteLine("0 - FIAT \n");
                    Console.WriteLine("1 - FORD \n");
                    Console.WriteLine("2 - CHEVROLET \n");
                    Console.WriteLine("3 - PEUGEOT \n");
                    Console.WriteLine("4 - RENAULT \n");
                    Console.WriteLine("5 - VOLKSWAGEN \n");
                    int brand = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Ingrese el modelo del auto: \n");
                    string model = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Ingrese el color del auto: \n");
                    string color = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Ingrese la cantidad de puertas del auto: \n");
                    byte doors = Convert.ToByte(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Ingrese el tipo de transmicion del auto: 0 - MANUAL, 1 - AUTOMATICO\n");
                    int type = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    newCar.CarID = carsCrud.maxId() + 1;
                    newCar.Brand = (Making_Sense.Brand)brand;
                    newCar.Model = model;
                    newCar.Color = color;
                    newCar.Doors = doors;
                    newCar.Type = (Making_Sense.Type)type;
                    Console.WriteLine("Auto creado: \n" + carsCrud.Create(newCar));
                    break;
                case 2:
                    Console.WriteLine("Ingrese el ID del auto a modificar: \n");
                    int newId = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        Console.WriteLine("El auto a modificar es el siguiente: \n" + carsCrud.Get(newId).ToString());
                        Console.WriteLine("Ingrese la nueva marca del auto: \n");
                        Console.WriteLine("0 - FIAT \n");
                        Console.WriteLine("1 - FORD \n");
                        Console.WriteLine("2 - CHEVROLET \n");
                        Console.WriteLine("3 - PEUGEOT \n");
                        Console.WriteLine("4 - RENAULT \n");
                        Console.WriteLine("5 - VOLKSWAGEN \n");
                        int newBrand = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Ingrese el nuevo modelo del auto: \n");
                        string newModel = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Ingrese el nuevo color del auto: \n");
                        string newColor = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Ingrese la cantidad de puertas del auto: \n");
                        byte newDoors = Convert.ToByte(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Ingrese el tipo de transmicion del auto: 0 - MANUAL, 1 - AUTOMATICO\n");
                        int newType = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        var modifiedCar = new Car
                        {
                            CarID = newId,
                            Brand = (Making_Sense.Brand)newBrand,
                            Model = newModel,
                            Color = newColor,
                            Doors = newDoors,
                            Type = (Making_Sense.Type)newType
                        };
                        Console.WriteLine(carsCrud.Update(modifiedCar).ToString());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("El auto no se encuentra en el archivo, ingrese el id correcto \n");
                    }                    
                    break;
                case 3:
                    Console.WriteLine("Ingrese el ID del auto a buscar: \n");
                    int idCar = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    try
                    {
                        Console.WriteLine(carsCrud.Get(idCar).ToString());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("El auto no se encuentra en el archivo, ingrese el id correcto \n");
                    }
                    break;
                case 4:
                    Console.WriteLine("Ingrese el ID del auto a eliminar: \n");
                    int idDelete = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    carsCrud.Delete(idDelete);
                    break;
                case 5:
                    foreach (Car car in carsCrud.GetAll())
                    {
                        Console.WriteLine(car.ToString());
                    }
                    break;
                default:
                    Console.WriteLine("Ingrese un numero correcto \n");
                    break;
            }
        }        
    }
}
