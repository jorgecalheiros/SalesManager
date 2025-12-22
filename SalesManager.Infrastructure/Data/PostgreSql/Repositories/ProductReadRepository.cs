using Microsoft.EntityFrameworkCore;
using SalesManager.Contracts.DTOs;
using SalesManager.Contracts.Interfaces.Repositories;

namespace SalesManager.Infrastructure.Data.PostgreSql.Repositories
{
    public class ProductReadRepository : IProductReadRepository
    {
        private readonly SalesManagerDbContext _context;
        public ProductReadRepository(SalesManagerDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ProductDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var query = from p in _context.Products.AsNoTracking()
                        select new ProductDto
                        {
                            Id = p.Id,
                            Name = p.Name,
                            Description = p.Description,
                            Price = p.Price,
                            Stock = p.Stock,
                            CreatedAt = p.CreatedAt,
                            UpdatedAt = p.UpdatedAt
                        };

            return await query.ToListAsync(cancellationToken).ConfigureAwait(false);
        }

        public async Task<ProductDto?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var query = from p in _context.Products.AsNoTracking()
                        where p.Id == id
                        select new ProductDto
                        {
                            Id = p.Id,
                            Name = p.Name,
                            Description = p.Description,
                            Price = p.Price,
                            Stock = p.Stock,
                            CreatedAt = p.CreatedAt,
                            UpdatedAt = p.UpdatedAt
                        };

            return await query.SingleOrDefaultAsync(cancellationToken).ConfigureAwait(false);
        }
    }
}
