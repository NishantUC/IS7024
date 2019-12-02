using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QuickTypeOwners;
using QuickTypeLicense;
using LicenseOwners.Models;

namespace LicenseOwners.Pages
{
    public class PrivacyModel : PageModel
    {
        BusinessLicenses[] businessLicenses = null;
        BusinessOwners[] businessOwners = null;
        BusinessLicenseOwners businessLicenseOwner = null;
        List<BusinessLicenseOwners> businessLicenseOwnersList = new List<BusinessLicenseOwners>();
        public JsonResult OnGet()
        {
            IndexModel index = new IndexModel();
            businessLicenses = BusinessLicenses.FromJson(index.getJSONData("https://data.cityofchicago.org/resource/r5kz-chrr.json?$where=account_number%20<%2051"));
            ViewData["BusinessLicenses"] = businessLicenses;

            businessOwners = BusinessOwners.FromJson(index.getJSONData("https://data.cityofchicago.org/resource/ezma-pppn.json?$where=account_number%20<%2051"));
            ViewData["BusinessOwners"] = businessOwners;

            IDictionary<string, BusinessLicenses> licenseDictionary = new Dictionary<string, BusinessLicenses>();

            foreach (BusinessLicenses businessLicense in businessLicenses)
            {
                if (!licenseDictionary.ContainsKey((businessLicense.AccountNumber + "_" + businessLicense.SiteNumber) + ""))
                {
                    licenseDictionary.Add((businessLicense.AccountNumber + "_" + businessLicense.SiteNumber) + "", businessLicense);
                }

            }

            foreach (BusinessOwners owners in businessOwners)
            {
                foreach (var license in licenseDictionary)
                {
                    if (license.Value.AccountNumber == owners.AccountNumber)
                    {
                        businessLicenseOwner = new BusinessLicenseOwners();
                        businessLicenseOwner.AccountNumber = license.Value.AccountNumber;
                        businessLicenseOwner.BusinessActivity = license.Value.BusinessActivity;
                        businessLicenseOwner.State = license.Value.State;
                        businessLicenseOwner.City = license.Value.City;
                        businessLicenseOwner.LicenseNumber = license.Value.LicenseNumber;
                        businessLicenseOwner.OwnerFirstName = owners.OwnerFirstName;
                        businessLicenseOwner.OwnerLastName = owners.OwnerLastName;
                        businessLicenseOwner.OwnerTitle = owners.OwnerTitle;
                        businessLicenseOwner.DoingBusinessAsName = license.Value.DoingBusinessAsName;
                        businessLicenseOwnersList.Add(businessLicenseOwner);
                    }
                }
            }
            return new JsonResult(businessLicenseOwnersList);


        }
    }
}