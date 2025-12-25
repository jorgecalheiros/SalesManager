using Microsoft.EntityFrameworkCore;
using SalesManager.Domain.Entities;
using SalesManager.Domain.Interfaces.Repositories;

namespace SalesManager.Infrastructure.Data.PostgreSql.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(SalesManagerDbContext context) : base(context)
        {
        }

        public async Task<Product?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var query = from product in _dbSet
                        where product.Id == id
                        select product;

            return await query.SingleOrDefaultAsync(cancellationToken).ConfigureAwait(false);
        }
    }
}
