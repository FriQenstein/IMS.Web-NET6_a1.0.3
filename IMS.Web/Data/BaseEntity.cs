using System.ComponentModel.DataAnnotations;

namespace IMS.Web.Data
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }


        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateModified { get; set; }
    }
}
