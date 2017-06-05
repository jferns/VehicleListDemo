using System;

namespace Carsales.Data.Models
{
    [Flags]
    public enum BikeType
    {
        Unknown = 0,
        Road    = 0x0100,
        OffRoad = 0x0200
    }
}
