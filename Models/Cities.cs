using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace AirQualityMVC.Models
{
    public class Cities
    {
        [DisplayName("Code")]
        public string Name { get; set; }
        public string Country { get; set; }
        [DisplayName("Number of Measurements")]
        public int Count { get; set; }
        public int Locations { get; set; }

    }
}
