using IMS.Web.Data;
using System.ComponentModel.DataAnnotations;

namespace IMS.Web.Models
{
    public class LeaveRequestVM : LeaveRequestCreateVM
    {
        public int Id { get; set; }
                
        [DataType(DataType.Date)]
        [Display(Name = "Date Requested")]
        [Required]
        public DateTime DateRequested { get; set; }

        [Display(Name = "Leave Type")]
        public LeaveTypeVM LeaveType { get; set; }

        [Display(Name = "Approvals")]
        public bool? Approved { get; set; }

        [Display(Name = "Status")]
        public bool Cancelled { get; set; }

        public string? RequestingEmployeeId { get; set; }
        public EmployeeListVM Employee { get; set; }
    }
}
