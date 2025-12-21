using SalesManager.Application.Common.SimpleMediator.Interfaces;

namespace SalesManager.Application.Common.CQRS
{
    public interface ICommand<TResponse> : IRequest<TResponse>
    {
        DateTimeOffset Timestamp { get; }
    }
}
