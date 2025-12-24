using SalesManager.Application.Common.CQRS;
using SalesManager.Contracts.DTOs;

namespace SalesManager.Application.Query.Product
{
    public class GetAllProductsQuery : IQuery<List<ProductDto>>
    {
        public DateTimeOffset Timestamp => DateTimeOffset.UtcNow;
    }
}
