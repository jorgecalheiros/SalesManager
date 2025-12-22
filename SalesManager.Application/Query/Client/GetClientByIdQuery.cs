using SalesManager.Application.Common.CQRS;
using SalesManager.Contracts.DTOs;

namespace SalesManager.Application.Query.Client
{
    public class GetClientByIdQuery : IQuery<ClientDto?>
    {
        public Guid Id { get; private set; }
        public DateTimeOffset Timestamp => DateTimeOffset.UtcNow;

        public GetClientByIdQuery(Guid id)
        {
            if (id == Guid.Empty) throw new ArgumentException("Cliente ID cannot be null");
            Id = id;
        }
    }
}
