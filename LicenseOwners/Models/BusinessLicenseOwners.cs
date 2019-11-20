
namespace LicenseOwners.Models
{
    public class BusinessLicenseOwners
    {
        public long AccountNumber { get; set; }
        public string DoingBusinessAsName { get; set; }
        public string OwnerFirstName { get; set; }
        public string OwnerLastName { get; set; }
        public string OwnerTitle { get; set; }

        public long LicenseNumber { get; set; }
        public string State { get; set; }
        public string BusinessActivity { get; set; }

        public string City { get; set; }

        public string CheckCity
        {
            get
            {
                if (!string.IsNullOrEmpty(City))
                {
                    return City;
                }
                return "N/A";
            }
        }
        public string CheckOwnerFirstName
        {
            get
            {
                if (!string.IsNullOrEmpty(OwnerFirstName))
                {
                    return OwnerFirstName;
                }
                return "N/A";
            }
        }
    }
}
