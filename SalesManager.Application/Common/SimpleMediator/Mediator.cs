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

        public async Task<TResponse> Send<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default)
        {
            var handlerType = typeof(IRequestHandler<,>).MakeGenericType(request.GetType(), typeof(TResponse));
            var handler = _provider.GetService(handlerType);
            if (handler == null)
            {
                throw new InvalidOperationException($"No handler found for request of type {request.GetType().FullName}");
            }

            return await (Task<TResponse>)handlerType
                .GetMethod("Handle")!
                .Invoke(handler, new object[] { request, cancellationToken })!;
        }
    }
}
