using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Web.Models;

namespace Portfolio.Web.Data.Configurations
{
    public class SkillConfiguration : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.SkillsTitle).IsRequired().HasMaxLength(100);
            builder.HasOne(x=>x.Category).WithMany(x=>x.Skills).HasForeignKey(x=>x.SkillCategoryId);
        }
    }
}
