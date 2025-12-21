using SalesManager.Application.Common.SimpleMediator.Interfaces;

namespace SalesManager.Application.Common.CQRS
{
    public interface ICommand<TCommandResponse> : IRequest<TCommandResponse>
    {
        DateTimeOffset Timestamp { get; }
    }
}
