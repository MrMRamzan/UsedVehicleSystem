using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UsedVehicleSystem.Models
{
    public class MotorBike
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
        [Required]
        public string imageUrl { get; set; }
        public string userID { get; set; }
    }
}