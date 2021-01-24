using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirQualityMVC.Misc
{
    public class ApiResponse<T>
    {
        public List<T> Results { get; set; }
    }
}
