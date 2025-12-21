using SalesManager.Application.Common.SimpleMediator.Interfaces;

namespace SalesManager.Application.Common.CQRS
{
    public interface ICommandHandler<in TCommand, TCommandResponse> : IRequestHandler<TCommand, TCommandResponse> where TCommand : ICommand<TCommandResponse>, IRequest<TCommandResponse>
    {
    }
}
