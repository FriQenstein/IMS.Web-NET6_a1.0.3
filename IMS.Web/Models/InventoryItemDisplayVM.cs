using System.ComponentModel.DataAnnotations;

namespace IMS.Web.Models
{
    public class InventoryItemDisplayVM
    {
        public int Id { get; set; }

        [Display(Name = "Client Name")]
        public string clientName { get; set; }

        [Display(Name = "Item Name")]
        public string itemName { get; set; }


        [Display(Name = "Qty")]
        public int itemQty { get; set; }


        [Display(Name = "Model")]
        public string? itemModel { get; set; }

        [Display(Name = "S/N")]
        public string? serialNumber { get; set; }


        [Display(Name = "Status")]
        public string itemStatus { get; set; }


        [Display(Name = "Notes")]
        public string? itemNotes { get; set; }
    }
}
