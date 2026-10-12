using Microsoft.EntityFrameworkCore;
using Task01EF.Models;

namespace Task01EF.Contexts
{
    public class Context : DbContext
    {
        public DbSet<class1> class1 { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=BookstoreDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<class1>(entity =>
            {
                entity.Property(b => b.Title)
                      .IsRequired()
                      .HasMaxLength(150);

                entity.Property(b => b.Price)
                      .HasColumnType("decimal(8,2)");

                entity.Property(b => b.PublishedDate)
                      .IsRequired(false);
            });
        }
    }
}