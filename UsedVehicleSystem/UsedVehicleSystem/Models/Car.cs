using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UsedVehicleSystem.Models
{
    public class Car
    {
        public int ID { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string title { get; set; }
        [Required]
        public string model { get; set; }
        [Required]
        public string make { get; set; }
        [Required]
        public float estimatedPrice { get; set; }
        [Required]
        public float drivenInKms { get; set; }
        [Required]
        public bool documents { get; set; }
        [Required]
        public bool condition { get; set; }

        [DataType(DataType.Upload)]
        [DisplayName("Front View of The Car")]
        public Byte Image { get; set; }

        [Required]
        public string imageUrl { get; set; }

        public string userID { get; set; }
    }
    public class VehiclesDBContext : DbContext {
        public DbSet<Car> Cars { set; get; }
        public DbSet<Bike> Bikes { set; get; }
        public DbSet<MotorBike> MotorBikes { set; get; }
        public DbSet<User> Users { set; get; }

        public DbSet<UsedVehicleSystem.Models.OfficeLocations> OfficeLocations { get; set; }

        public DbSet<UsedVehicleSystem.Models.Ads> Ads { get; set; }

    }
}