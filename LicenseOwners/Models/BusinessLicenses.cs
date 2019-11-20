namespace QuickTypeLicense
{
    using System;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class BusinessLicenses
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("license_id")]
        public long LicenseId { get; set; }

        [JsonProperty("account_number")]
        public long AccountNumber { get; set; }

        [JsonProperty("site_number")]
        public long SiteNumber { get; set; }

        [JsonProperty("legal_name")]
        public string LegalName { get; set; }

        [JsonProperty("doing_business_as_name")]
        public string DoingBusinessAsName { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip_code")]
        public long ZipCode { get; set; }

        [JsonProperty("ward")]
        public long Ward { get; set; }

        [JsonProperty("precinct")]
        public long Precinct { get; set; }

        [JsonProperty("ward_precinct")]
        public string WardPrecinct { get; set; }

        [JsonProperty("police_district")]
        public long PoliceDistrict { get; set; }

        [JsonProperty("license_code")]
        public long LicenseCode { get; set; }

        [JsonProperty("license_description")]
        public string LicenseDescription { get; set; }

    
        [JsonProperty("business_activity_id")]
        public string BusinessActivityId { get; set; }

        [JsonProperty("business_activity")]
        public string BusinessActivity { get; set; }

        [JsonProperty("license_number")]
        
        public long LicenseNumber { get; set; }

        [JsonProperty("application_type")]
        public string ApplicationType { get; set; }

        [JsonProperty("application_requirements_complete")]
        public DateTimeOffset ApplicationRequirementsComplete { get; set; }

        [JsonProperty("payment_date")]
        public DateTimeOffset PaymentDate { get; set; }

        [JsonProperty("conditional_approval")]
        public string ConditionalApproval { get; set; }

        [JsonProperty("license_start_date")]
        public DateTimeOffset LicenseStartDate { get; set; }

        [JsonProperty("expiration_date")]
        public DateTimeOffset ExpirationDate { get; set; }

        [JsonProperty("license_approved_for_issuance")]
        public DateTimeOffset LicenseApprovedForIssuance { get; set; }

        [JsonProperty("date_issued")]
        public DateTimeOffset DateIssued { get; set; }

        [JsonProperty("license_status")]
        public string LicenseStatus { get; set; }

        [JsonProperty("ssa")]
        public long Ssa { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

    }

    public partial class Location
    {
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("human_address")]
        public string HumanAddress { get; set; }
    }

    public partial class BusinessLicenses
    {
        public static BusinessLicenses[] FromJson(string json) => JsonConvert.DeserializeObject<BusinessLicenses[]>(json);
    }

    public static class Serialize
    {
        public static string ToJson(this BusinessLicenses[] self) => JsonConvert.SerializeObject(self);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
    
}
