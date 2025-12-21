using SalesManager.Domain.Entities;
using SalesManager.Domain.Interfaces.Repositories;

namespace SalesManager.Infrastructure.Data.PostgreSql.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(SalesManagerDbContext context) : base(context)
        {
        }
    }
}
