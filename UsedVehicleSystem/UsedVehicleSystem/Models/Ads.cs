using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace UsedVehicleSystem.Models
{
    public class Ads
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        [DisplayName("Advertisement Title")]
        public string AdTitle { get; set; }
        [DisplayName("Advertisement Category")]
        public string AdCategory { get; set; }
        
    }
}