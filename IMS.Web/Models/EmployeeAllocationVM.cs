using System.ComponentModel.DataAnnotations;

namespace IMS.Web.Models
{
    public class EmployeeAllocationVM : EmployeeListVM
    {
        public List<LeaveAllocationVM> LeaveAllocations { get; set; }
    }
}
