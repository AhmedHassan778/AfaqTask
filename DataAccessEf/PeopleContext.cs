
using Domain;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class PeopleContext : DbContext
    {
        /* protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             modelBuilder.Entity<Certification>()
                 .HasIndex(c => new { c.Name })
                 .IsUnique(true);
         }*/
        public PeopleContext(DbContextOptions options) : base(options) { }
        public DbSet<User> User
        {
            get;
            set;
        }

        public DbSet<Certification> Certification
        {
            get;
            set;
        }

    }
}
