using ApiWeb.Enum;

namespace ApiWeb.Models
{
    public class Car
    {
        public long CarID { get; set; }
        public Brand Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public byte Doors { get; set; }
        public Type Type { get; set; }
    }
}
