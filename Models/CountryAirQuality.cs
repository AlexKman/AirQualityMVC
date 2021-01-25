using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace AirQualityMVC.Models
{
    public class CountryAirQuality
    {
        [DisplayName("Code")]
        public string Code { get; set; }
        public string Name { get; set; }
        [DisplayName("Number of Cities")]
        public int Cities { get; set; }
        [DisplayName("Number of Measurements")]
        public int Count { get; set; }
        public int Locations { get; set; }
    }
}
