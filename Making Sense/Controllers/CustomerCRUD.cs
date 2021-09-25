using Making_Sence.Models;
using Making_Sense.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;

namespace Making_Sence.Controllers
{
    public class CustomerCRUD : ICRUD<Customer>
    {
        private readonly string jsonFileCustomer = ConfigurationManager.AppSettings["pathFileCustomer"];
        public List<Customer> customerList = new List<Customer>();
        public Customer Create(Customer customer)
        {
            if (GetDni(customer.DNI) >= 0)
            {
                Console.WriteLine("Ya existe un cliente con ese DNI \n");
            }
            else
            {
                customer.LastModificationDate = DateTime.Now;
                customerList.Add(customer);
                Save();
            }
            return customer;
        }
        private void Save()
        {
            string customerJson = JsonConvert.SerializeObject(customerList.ToArray(), Formatting.Indented);
            File.WriteAllText(jsonFileCustomer, customerJson);
        }
        public Customer Get(int id)
        {
            List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(Read());
            return customers.Single(client => client.customerID == id);
        }
        private string Read()
        {
            string customerJsonFromFile;
            using (var reader = new StreamReader(jsonFileCustomer))
            {
                customerJsonFromFile = reader.ReadToEnd();
            }
            return customerJsonFromFile;
        }
        public Customer Update(Customer customer)
        {
            customer.LastModificationDate = DateTime.Now;
            Customer aux = Get(customer.customerID);
            customerList.RemoveAt(aux.customerID);
            customerList.Add(customer);
            Save();
            return customer;
        }
        public void Delete(int id)
        {
            int index = customerList.FindIndex(i => i.customerID == id);
            if (index >= 0)
            {
                customerList.RemoveAt(index);
                Save();
            }
            else
            {
                Console.WriteLine("El cliente a eliminar no fue encontrado");
            }
        }
        public IEnumerable<Customer> GetAll()
        {
            return customerList.ToList().OrderBy(customer => customer.DNI);
        }
        public int GetDni(int dni)
        {
            return customerList.FindIndex(customer => customer.DNI == dni);
        }
    }
}
