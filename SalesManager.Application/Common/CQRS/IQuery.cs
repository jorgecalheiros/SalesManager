using SalesManager.Application.Common.SimpleMediator.Interfaces;

namespace SalesManager.Application.Common.CQRS
{
    public interface IQuery<TResult> : IRequest<TResult>
    {
        DateTimeOffset Timestamp { get; }
    }
}
