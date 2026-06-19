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

        public DbSet<HomePageSetting> HomePageSettings { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<SkillCategory> SkillCategorys { get; set; }
        public DbSet<LearningItem> LearningItems { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Certificate> Certificate { get; set; }
        public DbSet<Project> Projects { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(AppDbContext).Assembly);
        }

    }
}
