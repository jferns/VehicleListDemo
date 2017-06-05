namespace Carsales.Data.Models
{
    public class VehicleType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public VehicleClass VehicleClass { get; set; }

        public VehicleType()
        {

        }

        public VehicleType(string type, VehicleClass vClass)
        {
            Type = type;
            VehicleClass = vClass;
        }
    }
}
