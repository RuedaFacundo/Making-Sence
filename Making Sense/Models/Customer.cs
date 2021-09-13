namespace Making_Sence.Models
{
    public class Customer
    {
        public int DNI { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Telephone { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string LastModificationDate { get; set; }
        public override string ToString()
        {
            return "Cliente \n DNI:" + this.DNI + " - Name: " + this.Name + " - Surname: " + this.Surname + " - Telephone: " + this.Telephone + " - Adress: " + this.Adress + " - City: " + this.City + " - State: " + this.State + " - Zip Code: " + this.ZipCode + " - Last Modification Date: " + this.LastModificationDate + "\n";
        }
    }
}