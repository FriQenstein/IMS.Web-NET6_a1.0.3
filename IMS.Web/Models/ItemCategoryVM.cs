using System.ComponentModel.DataAnnotations;

namespace IMS.Web.Models
{
    public class ItemCategoryVM
    {
        public int Id { get; set; }

        [Display(Name = "Item Category")]
        public string itemCategory { get; set; }
    }
}
