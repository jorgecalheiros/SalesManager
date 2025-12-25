using SalesManager.Application.Common.CQRS;
using SalesManager.Contracts.DTOs.Sale;

namespace SalesManager.Application.Query.Sale
{
    public class GetAllSalesQuery : IQuery<List<SaleDto>>
    {
        public DateTimeOffset Timestamp => DateTimeOffset.UtcNow;
    }
}
