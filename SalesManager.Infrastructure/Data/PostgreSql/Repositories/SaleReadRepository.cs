using Microsoft.EntityFrameworkCore;
using SalesManager.Contracts.DTOs.Sale;
using SalesManager.Contracts.Interfaces.Repositories;

namespace SalesManager.Infrastructure.Data.PostgreSql.Repositories
{
    public class SaleReadRepository : ISaleReadRepository
    {
        private readonly IDbContextFactory<SalesManagerDbContext> _contextFactory;

        public SaleReadRepository(IDbContextFactory<SalesManagerDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<IEnumerable<SaleDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            using var context = await _contextFactory.CreateDbContextAsync(cancellationToken);

            return await context.Sales
                .AsNoTracking()
                .Select(s => new SaleDto
                {
                    Id = s.Id,
                    SaleDate = s.CreatedAt,
                    ClientName = s.Client.Name,
                    TotalValue = s.Items.Sum(i => i.UnitPrice * i.Quantity),
                    ItemCount = s.Items.Count()
                })
                .ToListAsync(cancellationToken).ConfigureAwait(false);
        }

        public async Task<SaleDto?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            using var context = await _contextFactory.CreateDbContextAsync(cancellationToken);

            return await context.Sales
                .AsNoTracking()
                .Where(s => s.Id == id)
                .Select(s => new SaleDto
                {
                    Id = s.Id,
                    SaleDate = s.CreatedAt,
                    ClientName = s.Client.Name,
                    TotalValue = s.Items.Sum(i => i.UnitPrice * i.Quantity),
                    ItemCount = s.Items.Count()
                })
                .SingleOrDefaultAsync(cancellationToken).ConfigureAwait(false);
        }

        public async Task<IEnumerable<SaleReportDto>> GetSalesReportByPeriodAsync(DateTime startDate, DateTime endDate, CancellationToken cancellationToken = default)
        {
            using var context = await _contextFactory.CreateDbContextAsync(cancellationToken);

            var startDateUtc = DateTime.SpecifyKind(startDate, DateTimeKind.Utc);
            var endDateUtc = DateTime.SpecifyKind(endDate, DateTimeKind.Utc);

            return await context.Sales
                    .AsNoTracking()
                    .Where(s => s.CreatedAt >= startDateUtc && s.CreatedAt <= endDateUtc)
                    .SelectMany(v => v.Items, (sale, item) =>
                    new SaleReportDto
                    {
                        ClientName = sale.Client.Name,
                        ClientEmail = sale.Client.Email,
                        SaleId = sale.Id,
                        SaleDate = sale.CreatedAt,
                        ProductName = item.Product.Name,
                        UnitPrice = item.Product.Price,
                        Quantity = item.Quantity
                    })
                    .OrderBy(x => x.SaleDate)
                    .ThenBy(x => x.SaleId)
                    .ToListAsync(cancellationToken);

        }
    }
}
