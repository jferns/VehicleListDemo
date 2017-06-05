namespace Carsales.Data.Models
{
    public class ModelEngine
    {
        public int VehicleModelId { get; set; }

        public int VehicleEngineId { get; set; }

        public VehicleModel VehicleModel { get; set; }
        public VehicleEngine VehicleEngine { get; set; }
    }
}
