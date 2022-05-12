using Microsoft.AspNetCore.Identity;

namespace IMS.Web.Data
{
    public class Client
    {
        public int Id { get; set; }
        public string companyName { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? emailAddress { get; set; }
        public string? bPhone { get; set; }
        public string? mPhone { get; set; }
        public string? streetAddress { get; set; }
        public string? cityName { get; set; }
        public string? stateName { get; set; }
        public string? postalCode { get; set; }
        public string? countryName { get; set; }
        public string? webAddress { get; set; }
        public string? Notes { get; set; }
    }
}
