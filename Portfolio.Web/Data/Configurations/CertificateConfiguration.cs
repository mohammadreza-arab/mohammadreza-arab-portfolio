using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Web.Models;

namespace Portfolio.Web.Data.Configurations
{
    public class CertificateConfiguration : IEntityTypeConfiguration<Certificate>
    {
        public void Configure(EntityTypeBuilder<Certificate> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Issuer).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Issuer).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Year).IsRequired().HasMaxLength(50);
        }
    }
}
