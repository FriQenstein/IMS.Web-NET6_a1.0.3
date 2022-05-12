using System.ComponentModel.DataAnnotations;

namespace IMS.Web.Models
{
    public class ItemTypeVM
    {
        public int Id { get; set; }

        [Display(Name = "Item Type")]
        public string itemType { get; set; }
    }
}
