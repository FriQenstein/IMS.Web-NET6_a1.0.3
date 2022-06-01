using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Web.Data
{
    public class LeaveAllocation : BaseEntity
    {
        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }  // set a Foreign key link/join to LeaveType table
        public int LeaveTypeId { get; set; }      // foreign key ** FK named same as TABLE + FIELD 'LeaveType+Id'

        public string EmployeeId { get; set; }

        public int NumberOfDays { get; set; }
    }
}
