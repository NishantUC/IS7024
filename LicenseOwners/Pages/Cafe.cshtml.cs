using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LicenseOwners;
using System.Net;

namespace LicenseOwners.Pages
{
    public class CafeModel : PageModel
    {
        public void OnGet()
        {

            string downloadedData = "";
            using (WebClient webClient = new WebClient())
            {
                downloadedData = webClient.DownloadString("https://caferecords20191109053359.azurewebsites.net/JSONFeed");
                LicenseOwners.Models.Cafe[] cafe = LicenseOwners.Models.Cafe.FromJson(downloadedData);
                ViewData["cafe"] = cafe;
            }

        }
    }
}