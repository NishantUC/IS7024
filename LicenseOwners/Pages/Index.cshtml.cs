using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QuickTypeOwners;
using QuickTypeLicense;

namespace LicenseOwners.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            List<BusinessOwners> businessLicenseOwners = new List<BusinessOwners>();
           
                BusinessLicenses[] businessLicenses = BusinessLicenses.FromJson(getJSONData("https://data.cityofchicago.org/resource/r5kz-chrr.json"));
                ViewData["BusinessLicenses"] = businessLicenses;

                BusinessOwners[] businessOwners = BusinessOwners.FromJson(getJSONData("https://data.cityofchicago.org/resource/ezma-pppn.json"));
                ViewData["BusinessOwners"] = businessOwners;
           

            IDictionary<string, BusinessLicenses> cafes = new Dictionary<string, BusinessLicenses>();

            foreach (BusinessLicenses businessLicense in businessLicenses)
            {
                cafes.Add(businessLicense.Id, businessLicense);
            }

            foreach (BusinessOwners owners in businessOwners)
            {
                foreach (var license in cafes)
                {
                    if (license.Value.AccountNumber == owners.AccountNumber)
                    {
                        businessLicenseOwners.Add(owners);
                    }
                }
               
            }
            ViewData["businessLicenseOwners"] = businessLicenseOwners;
        }

        public string getJSONData(String url)
        {
            String jsonString = "";
            using (var webClient = new WebClient())
            {
               jsonString = webClient.DownloadString(url);
            }
            return jsonString;
        }
    }
}
