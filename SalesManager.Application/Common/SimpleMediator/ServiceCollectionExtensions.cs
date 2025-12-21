using Microsoft.Extensions.DependencyInjection;
using SalesManager.Application.Common.SimpleMediator.Interfaces;
using System.Reflection;

namespace SalesManager.Application.Common.SimpleMediator
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSimpleMediator(this IServiceCollection services, Assembly assembly)
        {
            services.AddSingleton<IMediator, Mediator>();

            RegisterHandlers(services, assembly, typeof(IRequestHandler<,>));

            return services;
        }

        private static void RegisterHandlers(IServiceCollection services, Assembly assembly, Type handlerInterface)
        {
            var types = assembly.GetTypes()
                .Where(t => t.IsClass && !t.IsAbstract)
                .ToList();

            foreach (var type in types)
            {
                var interfaces = type.GetInterfaces()
                    .Where(i => i.IsGenericType && i.GetGenericTypeDefinition() == handlerInterface);

                foreach (var @interface in interfaces)
                {
                    services.AddTransient(@interface, type);
                }
            }
        }
    }
}
