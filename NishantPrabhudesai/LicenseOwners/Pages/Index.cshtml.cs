using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QuickType;

namespace LicenseOwners.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            using (var webClient = new WebClient())
            {
                string jsonString = webClient.DownloadString("https://data.cityofchicago.org/resource/r5kz-chrr.json");
                var businessLicenses = BusinessLicenses.FromJson(jsonString);
                ViewData["BusinessLicenses"] = businessLicenses;
            }
             
        }
    }
}
