using SalesManager.Application.Common.SimpleMediator.Interfaces;

namespace SalesManager.Application.Common.CQRS
{
    public interface IQuery<TResponse> : IRequest<TResponse>
    {
        DateTimeOffset Timestamp { get; }
    }
}
