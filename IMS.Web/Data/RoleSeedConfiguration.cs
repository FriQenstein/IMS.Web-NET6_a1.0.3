using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IMS.Web.Data
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole   // ADMIN ROLE
                {
                    Id = "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                },
                new IdentityRole  // USER ROLE
                {
                    Id = "36bfcd2c-aaaa-aaaa-aaaa-d5f719ffaaaa",
                    Name = "User",
                    NormalizedName = "USER"
                }
            );
        }
    }
}