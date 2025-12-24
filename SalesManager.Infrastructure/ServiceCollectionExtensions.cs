using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SalesManager.Contracts.Interfaces.Repositories;
using SalesManager.Domain.Interfaces.Repositories;
using SalesManager.Infrastructure.Data.PostgreSql;
using SalesManager.Infrastructure.Data.PostgreSql.Repositories;

namespace SalesManager.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, string connectionString = "")
        {
            if (!string.IsNullOrEmpty(connectionString)) services.AddPooledDbContextFactory<SalesManagerDbContext>(options => options.UseNpgsql(connectionString));

            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IClientReadRepository, ClientReadRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<ISaleRepository, SaleRepository>();
            services.AddScoped<ISaleReadRepository, SaleReadRepository>();

            return services;
        }
    }
}
