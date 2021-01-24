using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirQualityMVC.Controllers
{
    public class OpenAQAPI : Controller
    {
        public ActionResult Countries()
        {
            return View();
        }
    }
}
