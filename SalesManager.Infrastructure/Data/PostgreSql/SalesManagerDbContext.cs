using Microsoft.EntityFrameworkCore;
using SalesManager.Domain.Entities;

namespace SalesManager.Infrastructure.Data.PostgreSql
{
    public class SalesManagerDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleItem> SaleItems { get; set; }

        public SalesManagerDbContext(DbContextOptions<SalesManagerDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SalesManagerDbContext).Assembly);
        }
    }
}
