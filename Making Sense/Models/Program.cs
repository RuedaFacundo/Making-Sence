using Making_Sence.Models;
using System;
using System.Collections.Generic;

namespace Making_Sense.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            char continueMenu;
            do
            {
                Console.WriteLine("Seleccione una opcion: \n");
                Console.WriteLine(" 1 - Menu de autos \n");
                Console.WriteLine(" 2 - Menu de clientes \n");
                Console.WriteLine(" 3 - Menu de Alquileres \n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        CarMenu carMenu = new CarMenu();
                        carMenu.Menu();
                        break;
                    case 2:
                        Console.WriteLine("Ingreso a la opcion 2");
                        break;
                    case 3:
                        Console.WriteLine("Ingreso a la opcion 3");
                        break;
                    default:
                        Console.WriteLine("Ingrese un numero incorrecto, intente nuevamente");
                        break;
                }               
                Console.WriteLine("Desea finalizar el programa? s = si / n = no \n");
                continueMenu = Convert.ToChar(Console.ReadLine());
                Console.Clear();
            } while (continueMenu != 's');
        }
    }
}
