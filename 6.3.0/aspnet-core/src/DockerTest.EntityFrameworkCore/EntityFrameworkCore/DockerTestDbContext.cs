using Abp.Localization;
using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using DockerTest.Authorization.Roles;
using DockerTest.Authorization.Users;
using DockerTest.MultiTenancy;

namespace DockerTest.EntityFrameworkCore
{
    public class DockerTestDbContext : AbpZeroDbContext<Tenant, Role, User, DockerTestDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DockerTestDbContext(DbContextOptions<DockerTestDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationLanguageText>()
                .Property(p => p.Value)
                .HasMaxLength(100); // any integer that is smaller than 10485760
        }
    }
}
