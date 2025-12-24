using SalesManager.Application.Common.CQRS;
using SalesManager.Contracts.DTOs.Sale;
using SalesManager.Contracts.Interfaces.Repositories;

namespace SalesManager.Application.Query.Sale.Handlers
{
    public class GetSalesByPeriodQueryHandler : IQueryHandler<GetSalesByPeriodQuery, List<SaleReportDto>>
    {
        private readonly ISaleReadRepository _saleReadRepository;

        public GetSalesByPeriodQueryHandler(ISaleReadRepository saleReadRepository)
        {
            _saleReadRepository = saleReadRepository;
        }

        public async Task<List<SaleReportDto>> HandleAsync(GetSalesByPeriodQuery request, CancellationToken cancellationToken = default)
        {
            return (await _saleReadRepository.GetSalesReportByPeriodAsync(request.StartDate, request.EndDate)).ToList();
        }
    }
}
