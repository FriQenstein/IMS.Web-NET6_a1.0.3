using System.ComponentModel.DataAnnotations;

namespace IMS.Web.Models
{
    public class InventoryItemVM
    {
        public int Id { get; set; }

        [Display(Name = "Client Name")]
        public string clientName { get; set; }

        [Display(Name = "Item Name")]
        public string itemName { get; set; }

        [Display(Name = "Inbound Invoice")]
        public string? inboundInvoice { get; set; }

        [Display(Name = "Outbound Invoice")]
        public string? outboundInvoice { get; set; }

        [Display(Name = "Ship Date")]
        public DateTime? shipDate { get; set; }

        [Display(Name = "Qty")]
        public int itemQty { get; set; }

        [Display(Name = "Type")]
        public string itemType { get; set; }

        [Display(Name = "Category")]
        public string itemCategory { get; set; }

        [Display(Name = "Model")]
        public string itemModel { get; set; }

        [Display(Name = "S/N")]
        public string? serialNumber { get; set; }

        [Display(Name = "P/N")]
        public string? partNumber { get; set; }

        [Display(Name = "Location")]
        public string? itemLocation { get; set; }

        [Display(Name = "Status")]
        public string itemStatus { get; set; }

        [Display(Name = "Manufacturer")]
        public string? itemManufacturer { get; set; }

        [Display(Name = "Notes")]
        public string? itemNotes { get; set; }
    }
}
