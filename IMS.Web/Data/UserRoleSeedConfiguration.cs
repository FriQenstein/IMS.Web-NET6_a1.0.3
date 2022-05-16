using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IMS.Web.Data
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec",
                    UserId = "36bfcd2c-c68c-4c1a-82ac-d5f719ffccec"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "36bfcd2c-aaaa-aaaa-aaaa-d5f719ffaaaa",
                    UserId = "1100acdc2-c69c-abba-bac2-d5f719ffffaa"
                }
            );
        }
    }
}