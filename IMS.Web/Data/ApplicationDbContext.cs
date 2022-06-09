using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using IMS.Web.Data;
using IMS.Web.Models;

namespace IMS.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<Employee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
        }

        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocation { get; set; }

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