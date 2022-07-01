

using Cwk.Domain.Aggregates.PostAggregate;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CwkSocial.Dal.Configuration
{
    internal class IdentityUserTokenConfig : IEntityTypeConfiguration<IdentityUserToken<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserToken<string>> builder)
        {
            builder.HasNoKey();
        }
    }
}
