using Carsales.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carsales.DAL.Utils;

namespace Carsales.DAL.Context
{
    public class CarsalesContext : DbContext
    {
        public DbSet<VehicleMake> Makes { get; set; }
        public DbSet<VehicleModel> Models { get; set; }
        public DbSet<ModelDoors> ModelDoors { get; set; }
        public DbSet<ModelWheels> ModelWheels { get; set; }
        public DbSet<ModelVehicleType> ModelVehicleTypes { get; set; }

        public DbSet<VehicleEngine> Engines { get; set; }

        public DbSet<VehicleType> VehicleTypes { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }

        public CarsalesContext() : base("name=CarsalesDbCtxt")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<VehicleMake>(vm =>
           {
               vm.ToTable("VehicleMake", "dbo");
               vm.HasKey(p => p.Id);
               vm.Property(p => p.Id)
                    .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
               vm.Property(p => p.Make)
                    .HasMaxLength(100);
           });
        }
    }
}
