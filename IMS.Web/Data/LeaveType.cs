using System.ComponentModel.DataAnnotations;

namespace IMS.Web.Data
{
    public class LeaveType : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public int DefaultDays { get; set; }
    }
}
