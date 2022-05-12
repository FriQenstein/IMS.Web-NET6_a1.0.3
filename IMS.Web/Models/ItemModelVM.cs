using System.ComponentModel.DataAnnotations;

namespace IMS.Web.Models
{
    public class ItemModelVM
    {
        public int Id { get; set; }

        [Display(Name = "Item Model")]
        public string itemModel { get; set; }
    }
}
