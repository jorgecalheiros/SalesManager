using SalesManager.Application.Common.SimpleMediator.Interfaces;

namespace SalesManager.Application.Common.CQRS
{
    public interface ICommandHandler<TCommand, TCommandResponse> where TCommand : ICommand<TCommandResponse>, IRequestHandler<TCommand, TCommandResponse>
    {
        Task<TCommandResponse> HandleAsync(TCommand command, CancellationToken cancellationToken = default);
    }
}
