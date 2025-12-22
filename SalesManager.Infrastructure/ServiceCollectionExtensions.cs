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
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, string connectinString = "")
        {
            if (!string.IsNullOrEmpty(connectinString)) services.AddDbContext<SalesManagerDbContext>(options => options.UseNpgsql(connectinString));

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
