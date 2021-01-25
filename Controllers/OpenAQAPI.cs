using Microsoft.AspNetCore.Mvc;
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


                // Tests for successful response from API
                if (result.IsSuccessStatusCode)
                {
                    var task = result.Content.ReadAsAsync<ApiResponse<CountryAirQuality>>();

                    task.Wait();

                    Countries = removeWhereBlank(task.Result.Results);
                }
                else // If retrieval is unsuccessful display server error
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
                    ModelState.AddModelError(string.Empty, "Server Error: Please try again later");
                }
            }
            return View(Cities);
        }
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
    }
}
