using Microsoft.EntityFrameworkCore;
using SalesManager.Contracts.DTOs.Sale;
using SalesManager.Contracts.Interfaces.Repositories;

namespace SalesManager.Infrastructure.Data.PostgreSql.Repositories
{
    public class SaleReadRepository : ISaleReadRepository
    {
        private readonly SalesManagerDbContext _context;

        public SaleReadRepository(SalesManagerDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SaleDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var query = from s in _context.Sales.AsNoTracking()
                        join c in _context.Clients.AsNoTracking() on s.ClientId equals c.Id
                        join si in _context.SaleItems.AsNoTracking() on s.Id equals si.SaleId
                        select new SaleDto
                        {
                            Id = s.Id,
                            SaleDate = s.CreatedAt,
                            ClientName = c.Name,
                            TotalValue = s.Items.Sum(i => i.UnitPrice * i.Quantity),
                            ItemCount = s.Items.Count()
                        };

            return await query.ToListAsync(cancellationToken).ConfigureAwait(false);
        }

        public async Task<SaleDto?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var query = from s in _context.Sales.AsNoTracking()
                        join c in _context.Clients.AsNoTracking() on s.ClientId equals c.Id
                        join si in _context.SaleItems.AsNoTracking() on s.Id equals si.SaleId
                        where s.Id == id
                        select new SaleDto
                        {
                            Id = s.Id,
                            SaleDate = s.CreatedAt,
                            ClientName = c.Name,
                            TotalValue = s.Items.Sum(i => i.UnitPrice * i.Quantity),
                            ItemCount = s.Items.Count()
                        };

            return await query.SingleOrDefaultAsync(cancellationToken).ConfigureAwait(false);
        }

        public async Task<IEnumerable<SaleReportDto>> GetSalesReportByPeriodAsync(DateTime startDate, DateTime endDate, CancellationToken cancellationToken = default)
        {
            var query = from si in _context.SaleItems.AsNoTracking()
                        join s in _context.Sales.AsNoTracking() on si.SaleId equals s.Id
                        join c in _context.Clients.AsNoTracking() on s.ClientId equals c.Id
                        join p in _context.Products.AsNoTracking() on si.ProductId equals p.Id
                        where s.CreatedAt >= startDate && s.CreatedAt <= endDate
                        select new SaleReportDto
                        {
                            SaleId = s.Id,
                            SaleDate = s.CreatedAt,
                            ClientName = c.Name,
                            ProductName = p.Name,
                            Quantity = si.Quantity,
                            UnitPrice = si.UnitPrice,
                            SaleTotal = _context.SaleItems.Where(x => x.SaleId == s.Id)
                                                          .Sum(x => x.UnitPrice * x.Quantity)
                        };

            return await query.ToListAsync(cancellationToken).ConfigureAwait(false);
        }
    }
}
