using System.Web.Http;
using Carsales.Data;
using Carsales.Data.Models;

namespace Carsales.Web.api
{
    [RoutePrefix("api")]
    public class VehiclesController : ApiController
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public class Data
        {
            public int data { get; set; }
            public string myProperty { get; set; }
        }
        [Route("vehicles")]
        public IHttpActionResult GetVehicles()
        {
            log.Info("test log List Called");

            var list = new VehicleTest[]
            {
                new VehicleTest(0, VehicleClass.Car, "Holden", "Z1", "Petrol", 4, 4, (int)CarType.Sedan),
                new VehicleTest(0, VehicleClass.Car, "Holden", "HB1", "Petrol", 4, 4, (int)CarType.HatchBack),
                new VehicleTest(0, VehicleClass.Car, "BMW", "R1", "Petrol", 2, 0, (int)BikeType.OffRoad),
                new VehicleTest(0, VehicleClass.Car, "BMW", "OR1", "Petrol", 3, 0, (int)BikeType.Road)
            };
            return Ok(list);
        }
    }

    public class VehicleTest
    {
        public int Id { get; set; }
        public VehicleClass VehicleClass { get; set; }

        public string Name { get; set; }
        public string Image { get; set; }
        public string VehicleClassType { get; set; }

        public string Make { get; set; }
        public string Model { get; set; }
        public string Engine { get; set; }
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int VehicleType { get; set; }

        public VehicleTest()
        {

        }
        public VehicleTest(int id, VehicleClass vc, string mk, string md, string eng, int wh, int dr, int vt)
        {
            Id = id;
            VehicleClass = vc;
            Image = vc.ToString();
            VehicleClassType = vc.ToString();
            Make = mk;
            Model = md;
            Engine = eng;
            Wheels = wh;
            Doors = dr;
            VehicleType = vt;
            this.Name = mk + " - " + md + " - " + eng;
            if (vt == (int)CarType.Sedan)
            {
                this.Name += " (Sedan)";
            }
            else if (vt == (int)CarType.HatchBack)
            {
                this.Name += " (Hatch)";
            }
            else if (vt == (int)BikeType.Road)
            {
                this.Name += " (Road Bike)";
            }
            else if (vt == (int)BikeType.OffRoad)
            {
                this.Name += " (Off-Road Bike)";
            }

        }
    }

}
