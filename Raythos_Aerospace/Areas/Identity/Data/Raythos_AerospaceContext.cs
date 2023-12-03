using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Raythos_Aerospace.Areas.Identity.Data;

namespace Raythos_Aerospace.Areas.Identity.Data;

public class Raythos_AerospaceContext : IdentityDbContext<Raythos_AerospaceUser>
{
    public Raythos_AerospaceContext(DbContextOptions<Raythos_AerospaceContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }

    public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<Raythos_AerospaceUser>
    {
        public void Configure(EntityTypeBuilder<Raythos_AerospaceUser> builder)
        {
            builder.Property(x => x.FirstName).HasMaxLength(100);
            builder.Property(x =>x.LastName).HasMaxLength(100);

        }
    }
}
