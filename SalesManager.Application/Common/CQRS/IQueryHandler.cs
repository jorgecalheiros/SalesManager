using SalesManager.Application.Common.SimpleMediator.Interfaces;

namespace SalesManager.Application.Common.CQRS
{
    public interface IQueryHandler<in TQuery, TResponse> : IRequestHandler<TQuery, TResponse> where TQuery : IQuery<TResponse>, IRequest<TResponse>
    {
    }
}
