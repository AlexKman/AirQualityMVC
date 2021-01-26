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
    [Route("[controller]/[action]")]
    public class OpenAQAPI : Controller
    {
        // Provides list of countries from the API
        [Route("/")]
        public ActionResult Countries()
        {

            List<CountryAirQuality> Countries = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.openaq.org/v1/");

                var response = client.GetAsync("countries?limit=100");
                response.Wait();

                var result = response.Result;


                // Tests for successful response from API
                if (result.IsSuccessStatusCode)
                {
                    var task = result.Content.ReadAsAsync<ApiResponse<CountryAirQuality>>();

                    task.Wait();

                    Countries = removeWhereBlank(task.Result.Results);
                }
                else // If retrieval is unsuccessful display empty list
                {
                    Countries = new List<CountryAirQuality>();

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
        [Route("(C  ode)")]
        public ActionResult Cities(string Code)
        {

            IEnumerable<CitiesAirQuality> Cities = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.openaq.org/v1/");

                var response = client.GetAsync("cities?country=" + Code);

                response.Wait();

                var result = response.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<ApiResponse<CitiesAirQuality>>();
                    readTask.Wait();

                    Cities = removeWhereBlankCity(readTask.Result.Results);
                }
                else
                {
                    Cities = Enumerable.Empty<CitiesAirQuality>();
                }
            }
            return View(Cities);
        }
        //Removes cities where blank to avoid null reference errors
        public List<CitiesAirQuality> removeWhereBlankCity(List<CitiesAirQuality> newCities)
        {
            List<CitiesAirQuality> cities = new List<CitiesAirQuality>();
            foreach (var item in newCities)
            {
                if (item.Name != null && item.Name != "unused")
                {
                    cities.Add(item);
                }
            }

            return cities;
        }
        // Displays air quality measurements from specific City
        //[Route("[action]/(City)")]
        public ActionResult CityMeasurements(string Code)
        {
            IEnumerable<CityMeasurementResults> value = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.openaq.org/v1/");

                //Adds  only the latest measurements as the API contains 10's of thousands of  results for  some cities
                var response = client.GetAsync("latest?city=" + Code);

                response.Wait();

                var result = response.Result;

                if (result.IsSuccessStatusCode)
                {
                    var task = result.Content.ReadAsAsync<ApiResponse<CityMeasurementResults>>();

                    task.Wait();
                    value = task.Result.Results;
                }
                else
                {
                    value = Enumerable.Empty<CityMeasurementResults>();
                }
            }
            return View(value);
        }
    }
}
