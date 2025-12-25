using SalesManager.Application.Common.CQRS;
using SalesManager.Contracts.DTOs;

namespace SalesManager.Application.Query.Client
{
    public class GetAllClientQuery : IQuery<List<ClientDto>>
    {
        public DateTimeOffset Timestamp => DateTimeOffset.UtcNow;
    }
}
