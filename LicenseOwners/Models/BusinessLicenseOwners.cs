
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

        public string FullName
        {
            get
            {
                return OwnerFirstName + " " + OwnerLastName;
            }
        }
        public string CheckBusinessActivity
        {
            get
            {
                if(!string.IsNullOrEmpty(BusinessActivity))
                {
                    return BusinessActivity;
                }
                return "N/A";
            }
        }
    }
}
