using Microsoft.Extensions.DependencyInjection;
using SalesManager.Application.Common.SimpleMediator.Interfaces;
using System.Reflection;

namespace SalesManager.Application.Common.SimpleMediator
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSimpleMediator(this IServiceCollection services, Assembly[] assemblies)
        {
            services.AddSingleton<IMediator, Mediator>();

            RegisterHandlers(services, assemblies, typeof(IRequestHandler<,>));

            return services;
        }

        private static void RegisterHandlers(IServiceCollection services, Assembly[] assemblies, Type handlerInterface)
        {
            var types = assemblies.SelectMany(a => a.GetTypes())
                .Where(t => t.IsClass && !t.IsAbstract)
                .ToList();

            foreach (var type in types)
            {
                var interfaces = type.GetInterfaces()
                    .Where(t => t.IsGenericType && t.GetGenericTypeDefinition() == handlerInterface);

                foreach (var @interface in interfaces)
                {
                    services.AddTransient(@interface, type);
                }
            }
        }
    }
}
