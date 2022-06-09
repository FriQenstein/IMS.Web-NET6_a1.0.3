using System.ComponentModel.DataAnnotations;

namespace IMS.Web.Models
{
    public class LeaveAllocationVM
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "Number Of Days")]
        [Required]
        [Range(1, 50, ErrorMessage ="Invalid value entered!")]
        public int NumberOfDays { get; set; }

        [Display(Name = "Allocation Period")]
        [Required]
        public int Period { get; set; }
        public LeaveTypeVM? LeaveType { get; set; }
    }
}