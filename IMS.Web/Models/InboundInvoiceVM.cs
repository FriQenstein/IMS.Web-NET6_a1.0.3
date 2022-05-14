using System.ComponentModel.DataAnnotations;

namespace IMS.Web.Models
{
    public class InboundInvoiceVM
    {
        public int Id { get; set; }

        [Display(Name = "Invoice Number")]
        public string invoiceNumber { get; set; }

        [Display(Name = "Client Name")]
        public string clientName { get; set; }

        [Display(Name = "Invoice Date")]
        [DataType(DataType.Date)]
        public DateTime? invoiceDate { get; set; }

        [Display(Name = "Invoice Notes")]
        public string? invoiceNotes { get; set; }
    }
}
