using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace AirQualityMVC.Models
{
    public class Countries
    {
        [DisplayName("Code")]
        public string Code { get; set; }
        public string Name { get; set; }

        public int Cities { get; set; }

        public int Count { get; set; }
        public int Locations { get; set; }
    }
}
