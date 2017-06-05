using System.Collections.Generic;

namespace Carsales.Data.Models
{
    public class VehicleModel
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int MakeId { get; set; }

        public VehicleClass VehicleClass { get; set; }


        public List<ModelEngine> ModelEngines { get; set; }
        public List<ModelDoors> ModelDoors { get; set; }
        public List<ModelWheels> ModelWheels { get; set; }
        public List<ModelVehicleType> ModelVehicleTypes { get; set; }

        public VehicleMake Make { get; set; }

        public VehicleModel()
        {

        }
        public VehicleModel(string model, int makeId, VehicleClass vClass)
        {
            VehicleClass = vClass;
            MakeId = makeId;

            Model = model;
        }
    }
}
