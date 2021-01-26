using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace AirQualityMVC.Models
{
    public class CitiesAirQuality

    {
        public string Country { get; set; }
        
        public string Name { get; set; }
        [DisplayName("Number of Measurements")]
        public int Count { get; set; }

    }
}
