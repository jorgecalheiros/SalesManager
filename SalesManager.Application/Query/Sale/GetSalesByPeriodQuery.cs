using SalesManager.Application.Common.CQRS;
using SalesManager.Contracts.DTOs.Sale;

namespace SalesManager.Application.Query.Sale
{
    public class GetSalesByPeriodQuery : IQuery<List<SaleReportDto>>
    {
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; } = DateTime.MinValue;
        public DateTimeOffset Timestamp => DateTimeOffset.UtcNow;

        public GetSalesByPeriodQuery(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
