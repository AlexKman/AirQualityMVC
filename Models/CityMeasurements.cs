using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace AirQualityMVC.Models
{

    public class CityMeasurements
    {
        public double Value { get; set; }
        public string Unit { get; set; }
        public string Parameter { get; set; }
    }
    public class CityMeasurementResults
    {
        public List<CityMeasurements> Measurements { get; set; }
        public string Location { get; set; }
        public string City { get; set; }
    
     
    }
}
