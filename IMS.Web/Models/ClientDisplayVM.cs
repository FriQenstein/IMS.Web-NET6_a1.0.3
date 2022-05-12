using System.ComponentModel.DataAnnotations;

namespace IMS.Web.Models
{
    public class ClientDisplayVM
    {
        public int Id { get; set; }

        [Display(Name = "Company")]
        [Required]
        public string companyName { get; set; }

        [Display(Name = "First Name")]
        public string? firstName { get; set; }

        [Display(Name = "Last Name")]
        public string? lastName { get; set; }
    }
}
