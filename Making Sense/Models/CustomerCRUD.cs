using Making_Sense.Interface.ICarCrud;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace Making_Sence.Models
{
    public class CustomerCRUD : ICRUD<Customer>
    {
        private readonly string jsonFileCustomer = ConfigurationManager.AppSettings["pathFileCustomer"];
        public List<Customer> customerList = new List<Customer>();
        public Customer Create(Customer customer)
        {
            customerList.Add(customer);
            Save();
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
            var customer = new Customer();
            foreach (var client in customers)
            {
                if (client.customerID == id)
                {
                    aux = client;
                }
            }
            return aux;
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
    }
}
