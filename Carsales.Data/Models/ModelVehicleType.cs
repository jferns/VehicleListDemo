namespace Carsales.Data.Models
{
    public class ModelVehicleType
    {
        public int VehicleModelId { get; set; }

        public int VehicleTypeId { get; set; }

        public VehicleModel VehicleModel { get; set; }
        public VehicleType VehicleType { get; set; }
    }
}
