using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirQualityMVC.Models
{
    public class CityMeasurements
    {
        public string Parameter { get; set; }
        public string Unit { get; set; }
        public double Value { get; set; }
    }
}
