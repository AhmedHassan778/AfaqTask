
using DataAccessEf.Configrations;
using Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class PeopleContext : IdentityDbContext<User>
    {
        /* protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             modelBuilder.Entity<Certification>()
                 .HasIndex(c => new { c.Name })
                 .IsUnique(true);
         }*/
        public PeopleContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
        }

        public DbSet<Certification> Certification
        {
            get;
            set;
        }

    }
}
