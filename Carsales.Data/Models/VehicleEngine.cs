namespace Carsales.Data.Models
{
    public class VehicleEngine
    {
        public int Id { get; set; }
        public string Engine { get; set; }

        public VehicleClass VehicleClass { get; set; }
        public VehicleEngine()
        {

        }
        public VehicleEngine(string engine, VehicleClass vClass)
        {
            Engine = engine;
            VehicleClass = vClass;
        }
    }
}
