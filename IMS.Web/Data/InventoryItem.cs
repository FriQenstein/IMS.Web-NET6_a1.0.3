namespace IMS.Web.Data
{
    public class InventoryItem
    {
        public int Id { get; set; }
        public string clientName { get; set; }
        public string itemName { get; set; }
        public string? inboundInvoice { get; set; }
        public string? outboundInvoice { get; set; }
        public DateTime? shipDate { get; set; }
        public int itemQty { get; set; }
        public string itemType { get; set; }
        public string itemCategory { get; set; }
        public string? itemModel { get; set; }
        public string? serialNumber { get; set; }
        public string? partNumber { get; set; }
        public string? itemLocation { get; set; }
        public string itemStatus { get; set; }
        public string? itemManufacturer { get; set; }
        public string? itemNotes { get; set; }
    }
}
