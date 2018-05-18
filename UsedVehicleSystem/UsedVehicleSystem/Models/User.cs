using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UsedVehicleSystem.Models
{
    public class User
    {
        public int ID { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [Required]
        [DisplayName("Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required]
        [DisplayName("Email ID")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DisplayName("Your Complete Address")]
        public string Address { get; set; }
        [DisplayName("State or Province")]
        public string StateOrProvince { get; set; }
        [DisplayName("Your City Name")]
        public string CityName { get; set; }
        [DisplayName("Zip Code")]
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }

    }
}