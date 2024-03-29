﻿using System.ComponentModel.DataAnnotations;

namespace IMS.Web.Data
{
    public class InboundInvoice
    {
        public int Id { get; set; }
        public string invoiceNumber { get; set; }
        public string clientName { get; set; }

        [DataType(DataType.Date)]
        public DateTime? invoiceDate { get; set; }

        public string? invoiceNotes { get; set; }
    }
}
