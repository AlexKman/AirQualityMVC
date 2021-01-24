﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using AirQualityMVC.Models;
using AirQualityMVC.Misc;

namespace AirQualityMVC.Controllers
{
    public class OpenAQAPI : Controller
    {
        // Provides list of countries from the API
        public ActionResult Countries()
        {

            List<CountryAirQuality> Countries = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.openaq.org/v1/");

                var response = client.GetAsync("countries?limit=100");
                response.Wait();

                var result = response.Result;

                if (result.IsSuccessStatusCode)
                {
                    var task = result.Content.ReadAsAsync<ApiResponse<CountryAirQuality>>();

                    task.Wait();

                    Countries = removeWhereBlank(task.Result.Results);
                }
                else
                {
                    Countries = new List<CountryAirQuality>();
                    ModelState.AddModelError(string.Empty, "Server Error");



                }
            }
            return View(Countries);
        }

        //Removes countries where blank to avoid null reference errors
        public List<CountryAirQuality> removeWhereBlank(List<CountryAirQuality> airQualityCountries)
        {
            List<CountryAirQuality> countries = new List<CountryAirQuality>();
            foreach (var item in airQualityCountries)
            {
                if (item.Name != null && item.Name != "")
                {
                    countries.Add(item);
                }
            }

            return countries;
        }
    }
}
