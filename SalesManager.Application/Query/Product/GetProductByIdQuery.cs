using SalesManager.Application.Common.CQRS;
using SalesManager.Contracts.DTOs;

namespace SalesManager.Application.Query.Product
{
    public class GetProductByIdQuery : IQuery<ProductDto?>
    {
        public Guid Id { get; private set; }
        public DateTimeOffset Timestamp => DateTimeOffset.UtcNow;

        public GetProductByIdQuery(Guid id)
        {
            if (id == Guid.Empty) throw new ArgumentException("Cliente ID cannot be null");
            Id = id;
        }
    }
}
