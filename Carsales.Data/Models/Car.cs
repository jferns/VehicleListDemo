namespace Carsales.Data.Models
{
    public class Car : Vehicle
    {
        public int Doors { get; set; }
        public Car()
        {
            VehicleClass = VehicleClass.Car;
        }
    }
}
