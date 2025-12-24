using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using SalesManager.Application.Common.SimpleMediator.Interfaces;

namespace SalesManager.Application.Common.SimpleMediator
{
    public class Mediator : IMediator
    {
        private readonly IServiceProvider _provider;

        public Mediator(IServiceProvider provider)
        {
            _provider = provider;
        }

        public async Task<TResponse> SendAsync<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default)
        {
            await ValidateAsync(request);

            var handlerType = typeof(IRequestHandler<,>).MakeGenericType(request.GetType(), typeof(TResponse));
            var handler = _provider.GetService(handlerType);
            if (handler == null)
            {
                throw new InvalidOperationException($"No handler found for request of type {request.GetType().FullName}");
            }

            return await (Task<TResponse>)handlerType
                .GetMethod("HandleAsync")!
                .Invoke(handler, new object[] { request, cancellationToken })!;
        }

        private async Task ValidateAsync<T>(T request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            var validatorType = typeof(IValidator<>).MakeGenericType(request.GetType());
            var validators = _provider.GetServices(validatorType).Cast<IValidator>();

            if (!validators.Any())
                return;

            var context = new ValidationContext<T>(request);

            var failures = validators
                .Select(v => v.Validate(context))
                .SelectMany(result => result.Errors)
                .Where(f => f != null)
                .ToList();

            if (failures.Count != 0)
            {
                throw new ValidationException(failures);
            }

            await Task.CompletedTask;
        }
    }
}
