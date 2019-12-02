using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QuickTypeOwners;
using QuickTypeLicense;
using LicenseOwners.Models;
using Microsoft.AspNetCore.Http;

namespace LicenseOwners.Pages
{
    public class IndexModel : PageModel
    {
        HashSet<String> BusinessActivitySet = null;
        BusinessLicenses[] businessLicenses = null;
        BusinessOwners[] businessOwners = null;
        
        List<BusinessLicenseOwners> businessLicenseOwnersList = new List<BusinessLicenseOwners>();
        BusinessLicenseOwners businessLicenseOwner = null;
        IDictionary<string, BusinessLicenses> licenseDictionary = null;
        

        public bool DataFetched { get; set; }

        public void OnPost()
        {
            DataFetched=true;

            businessLicenses = BusinessLicenses.FromJson(getJSONData(createURL("https://data.cityofchicago.org/resource/r5kz-chrr.json?$where=account_number%20<%2051",Request.Form["Activity"])));
            ViewData["BusinessLicenses"] = businessLicenses;

            businessOwners = BusinessOwners.FromJson(getJSONData("https://data.cityofchicago.org/resource/ezma-pppn.json?$where=account_number%20<%2051"));
            ViewData["BusinessOwners"] = businessOwners;
            searchJSON();
        }

       public String createURL(String url,String filterValue)
        {
            String finalURL = url;
            if (filterValue != "")
            {
                finalURL = url + "&&business_activity=" + filterValue;
            }
            return finalURL;
        }

        public void searchJSON()
        {
            BusinessActivitySet = new HashSet<string>();
            
            licenseDictionary = new Dictionary<string, BusinessLicenses>();

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
                        if (license.Value.BusinessActivity!=null &&  license.Value.BusinessActivity.Trim()!="")
                        {
                            BusinessActivitySet.Add(license.Value.BusinessActivity);
                            
                        }
                        
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
            
          //  HttpContext.Session.Set("BusinessActivitySet", new byte[](BusinessActivitySet)); 
            ViewData["BusinessLicenseOwners"] = businessLicenseOwnersList;
            if (DataFetched) {
                //ViewData["BusinessActivitySet"] = BusinessActivitySet;
                BusinessActivitySet = new HashSet<string>();
                businessLicenses = BusinessLicenses.FromJson(getJSONData(createURL("https://data.cityofchicago.org/resource/r5kz-chrr.json?$where=account_number%20<%2051", "")));


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
                            if (license.Value.BusinessActivity != null && license.Value.BusinessActivity.Trim() != "")
                            {
                                BusinessActivitySet.Add(license.Value.BusinessActivity);
                            }
                        }
                    }

                }
                ViewData["BusinessActivitySet"] = BusinessActivitySet;
                
            }
            else
            {
                ViewData["BusinessActivitySet"] = BusinessActivitySet;
            }

            
        }

        public void OnGet()
        {
            DataFetched = false;
            
                businessLicenses = BusinessLicenses.FromJson(getJSONData(createURL("https://data.cityofchicago.org/resource/r5kz-chrr.json?$where=account_number%20<%2051","")));
                ViewData["BusinessLicenses"] = businessLicenses;

                businessOwners = BusinessOwners.FromJson(getJSONData("https://data.cityofchicago.org/resource/ezma-pppn.json?$where=account_number%20<%2051"));
                ViewData["BusinessOwners"] = businessOwners;
                searchJSON();
            
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
