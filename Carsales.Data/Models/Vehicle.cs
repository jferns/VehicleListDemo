namespace Carsales.Data.Models
{
    public abstract class Vehicle
    {
        public int Id { get; set; }
        public VehicleClass VehicleClass { get; set; }

        public int MakeId { get; set; }
        public int ModelId { get; set; }
        public int EngineId { get; set; }
        public int Wheels { get; set; }
        public int VehicleTypeId { get; set; }

        public VehicleMake Make { get; set; }
        public VehicleModel Model { get; set; }
        public VehicleEngine Engine { get; set; }
        public VehicleType VehicleType { get; set; }
    }
}
