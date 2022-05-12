using System.ComponentModel.DataAnnotations;

namespace IMS.Web.Models
{
    public class ItemStatusVM
    {
        public int Id { get; set; }

        [Display(Name = "Item Status")]
        public string itemStatus { get; set; }
    }
}
