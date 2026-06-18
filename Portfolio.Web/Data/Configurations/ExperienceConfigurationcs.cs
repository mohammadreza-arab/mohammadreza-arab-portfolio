using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Web.Models;

namespace Portfolio.Web.Data.Configurations
{
    public class ExperienceConfigurationcs : IEntityTypeConfiguration<Experience>
    {
        public void Configure(EntityTypeBuilder<Experience> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.Property(x=>x.Title).IsRequired().HasMaxLength(100);
            builder.Property(x=>x.Year).IsRequired().HasMaxLength(50);
            builder.Property(x=>x.CompanyName).IsRequired().HasMaxLength(100);
            builder.Property(x=>x.CompanyUrl).IsRequired().HasMaxLength(100);
            builder.Property(x=>x.Description).IsRequired().HasMaxLength(250);
            builder.Property(x=>x.WorkInfo).IsRequired().HasMaxLength(100);
        }
    }
}
