using SalesManager.Application.Common.CQRS;
using SalesManager.Contracts.DTOs.Sale;
using SalesManager.Contracts.Interfaces.Repositories;

namespace SalesManager.Application.Query.Sale.Handlers
{
    public class GetAllSalesQueryHandler : IQueryHandler<GetAllSalesQuery, List<SaleDto>>
    {
        private readonly ISaleReadRepository _saleReadRepository;

        public GetAllSalesQueryHandler(ISaleReadRepository saleReadRepository)
        {
            _saleReadRepository = saleReadRepository;
        }

        public async Task<List<SaleDto>> HandleAsync(GetAllSalesQuery request, CancellationToken cancellationToken = default)
        {
            return (await _saleReadRepository.GetAllAsync(cancellationToken)).ToList();
        }
    }
}
