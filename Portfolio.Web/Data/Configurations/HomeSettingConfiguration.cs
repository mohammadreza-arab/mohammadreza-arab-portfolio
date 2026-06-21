using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Web.Models;

namespace Portfolio.Web.Data.Configurations
{
    public class HomeSettingConfiguration : IEntityTypeConfiguration<HomePageSetting>
    {
        public void Configure(EntityTypeBuilder<HomePageSetting> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.HeroTitle).IsRequired().HasMaxLength(100);
            builder.Property(x=>x.HeroName).IsRequired().HasMaxLength(100);
            builder.Property(x=>x.HeroDescription).IsRequired().HasMaxLength(300);
            builder.Property(x=>x.HeroLocation).IsRequired().HasMaxLength(100);
            builder.Property(x=>x.HeroStatus).IsRequired().HasMaxLength(100);
            builder.Property(x=>x.HeroFocus).IsRequired().HasMaxLength(100);
            builder.Property(x=>x.HeroLanguage).IsRequired().HasMaxLength(100);
            builder.Property(x=>x.AboutTitle).IsRequired().HasMaxLength(100);
            builder.Property(x=>x.AboutSummary).IsRequired().HasMaxLength(100);
            builder.Property(x=>x.AboutDescription).IsRequired().HasMaxLength(500);
            builder.Property(x=>x.TitleContact).IsRequired().HasMaxLength(100);
            builder.Property(x=>x.Email).IsRequired();
            builder.Property(x => x.EmailUrl).IsRequired();
            builder.Property(x => x.GithubUrl).IsRequired();
            builder.Property(x => x.MetaTitle).IsRequired().HasMaxLength(100);
            builder.Property(x => x.MetaDescription).IsRequired().HasMaxLength(250);

        }
    }
}
