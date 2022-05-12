using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using IMS.Web.Data;

namespace IMS.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<Employee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }

        public DbSet<ItemType> ItemType { get; set; }

        public DbSet<ItemCategory> ItemCategory { get; set; }
        public DbSet<InboundInvoice> InboundInvoices { get; set; }
        public DbSet<OutboundInvoice> OutboundInvoices { get; set; }
        public DbSet<ItemModel> ItemModels { get; set; }
        public DbSet<ItemStatus> ItemStatuses { get; set; }
        public DbSet<InventoryItem> InventoryItems { get; set; }
    }
}