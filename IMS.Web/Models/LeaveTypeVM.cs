using System.ComponentModel.DataAnnotations;

namespace IMS.Web.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Display(Name = "Leave Type Name")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Default # of Days")]
        [Required]
        public int DefaultDays { get; set; }
    }
}
