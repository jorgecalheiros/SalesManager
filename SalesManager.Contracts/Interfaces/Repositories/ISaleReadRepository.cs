using SalesManager.Contracts.DTOs.Sale;

namespace SalesManager.Contracts.Interfaces.Repositories
{
    public interface ISaleReadRepository
    {
        Task<IEnumerable<SaleDto>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<SaleDto?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<IEnumerable<SaleReportDto>> GetSalesReportByPeriodAsync(DateTime startDate, DateTime endDate, CancellationToken cancellationToken = default);
    }
}
