using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SalesManager.Infrastructure.Data.PostgreSql;

namespace SalesManager.Application.Integration.Tests.Fixture
{
    public class ApplicationFixture : IDisposable
    {
        public IServiceProvider ServiceProvider { get; private set; }
        private readonly SqliteConnection _connection;

        public ApplicationFixture()
        {
            Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", "Testing");

            var services = new ServiceCollection();

            _connection = new SqliteConnection("DataSource=:memory:");
            _connection.Open();

            services.AddApplicationServices();

            services.AddDbContext<SalesManagerDbContext>(options =>
            {
                options.UseSqlite(_connection);
            });

            ServiceProvider = services.BuildServiceProvider();

            using var scope = ServiceProvider.CreateScope();
            scope.ServiceProvider.GetRequiredService<SalesManagerDbContext>().Database.EnsureCreated();
        }

        public SalesManagerDbContext CreateContext()
        => ServiceProvider.GetRequiredService<SalesManagerDbContext>();

        public void Dispose()
        {
            _connection.Close();
            _connection.Dispose();
        }
    }
}
