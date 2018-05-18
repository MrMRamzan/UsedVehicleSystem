using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UsedVehicleSystem.Models
{
    public class OfficeLocations
    {
        public int ID { get; set; }
        [DisplayName("Office Complete Address")]
        public string Address { get; set; }
        [DisplayName("State or Province")]
        public string StateOrProvince { get; set; }
        [DisplayName("Office City Name")]
        public string CityName { get; set; }
        [DisplayName("Zip Code")]
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }
    }
}