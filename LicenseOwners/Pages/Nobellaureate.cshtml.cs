using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LicenseOwners.Models;

namespace LicenseOwners.Pages
{
    public class NobellaureateModel : PageModel
    {
        public void OnGet()
        {

            NobleLaureate[] nobelLaureate = NobleLaureate.FromJson(getJSONData("https://data.cityofchicago.org/resource/r5kz-chrr.json?$where=account_number%20<%2051"));
            ViewData["NobelLaureate"] = nobelLaureate;
        }

        public string getJSONData(String url)
        {
            String jsonString = "";
            using (var webClient = new System.Net.WebClient())
            {
                jsonString = webClient.DownloadString(url);
            }

            return jsonString;
        }
    }
}