using Microsoft.EntityFrameworkCore;
using Portfolio.Web.Data.Configurations;
using Portfolio.Web.Models;

namespace Portfolio.Web.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
         : base(options)
        {
        }

        public DbSet<HomePageSetting> homePageSettings { get; set; }
        public DbSet<Skill> skill { get; set; }
        public DbSet<SkillCategory> skillCategorys { get; set; }
        public DbSet<LearningItem> LearningItems { get; set; }
        public DbSet<Experience> experiences { get; set; }
        public DbSet<Education> educations { get; set; }
        public DbSet<Certificate> certificate { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(AppDbContext).Assembly);
        }

    }
}
