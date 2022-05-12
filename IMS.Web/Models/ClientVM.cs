using System.ComponentModel.DataAnnotations;

namespace IMS.Web.Models
{
    public class ClientVM
    {
        public int Id { get; set; }

        [Display(Name = "Company")]
        [Required]
        public string companyName { get; set; }

        [Display(Name = "First Name")]
        public string? firstName { get; set; }

        [Display(Name = "Last Name")]
        public string? lastName { get; set; }


        [Display(Name = "E-mail")]
        public string? emailAddress { get; set; }

        [Display(Name = "Office #")]
        public string? bPhone { get; set; }

        [Display(Name = "Mobile #")]
        public string? mPhone { get; set; }

        [Display(Name = "Address")]
        public string? streetAddress { get; set; }

        [Display(Name = "City")]
        public string? cityName { get; set; }

        [Display(Name = "State")]
        public string? stateName { get; set; }

        [Display(Name = "Post Code")]
        public string? postalCode { get; set; }

        [Display(Name = "Country")]
        public string? countryName { get; set; }

        [Display(Name = "Website")]
        public string? webAddress { get; set; }

        [Display(Name = "Notes")]
        public string? Notes { get; set; }
    }
}
