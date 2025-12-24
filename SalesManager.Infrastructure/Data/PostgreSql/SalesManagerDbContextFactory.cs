using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace SalesManager.Infrastructure.Data.PostgreSql
{
    public class SalesManagerDbContextFactory : IDesignTimeDbContextFactory<SalesManagerDbContext>
    {
        public SalesManagerDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SalesManagerDbContext>();

            // just use when run migrations are needed
            string connectionString = "";
            optionsBuilder.UseNpgsql(connectionString);

            return new SalesManagerDbContext(optionsBuilder.Options);
        }
    }
}
