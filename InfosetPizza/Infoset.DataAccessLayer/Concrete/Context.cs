using Infoset.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Infoset.DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=DbInfosetPizza;integrated security=true");
        }
        public DbSet<Branch> Branches { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Branch>().HasKey(x => x.id);
            modelBuilder.Entity<Branch>().Property(x => x.name).HasMaxLength(100);
        }

    }
}
