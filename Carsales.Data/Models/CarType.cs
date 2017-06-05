using System;

namespace Carsales.Data.Models
{
    [Flags]
    public enum CarType
    {
        Unknown = 0,
        Sedan       = 0x0002,
        HatchBack   = 0x0001
    }
}
