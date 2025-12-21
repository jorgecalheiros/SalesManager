using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using SalesManager.Application.Common.SimpleMediator;
using SalesManager.Infrastructure;

namespace SalesManager.Application
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, string connectionString)
        {
            services.AddValidatorsFromAssembly(typeof(ServiceCollectionExtensions).Assembly);

            services.AddSimpleMediator(typeof(ServiceCollectionExtensions).Assembly);

            services.AddInfrastructureServices(connectionString);

            return services;
        }
    }
}
