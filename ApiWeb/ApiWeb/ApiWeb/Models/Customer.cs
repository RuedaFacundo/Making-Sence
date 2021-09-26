using System;

namespace ApiWeb.Models
{
    public class Customer
    {
        public long CustomerID { get; set; }
        public int DNI { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Telephone { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public DateTime LastModificationDate { get; set; }
    }
}
