using SalesManager.Domain.Entities;
using SalesManager.Domain.Interfaces.Repositories;

namespace SalesManager.Infrastructure.Data.PostgreSql.Repositories
{
    public class SaleRepository : BaseRepository<Sale>, ISaleRepository
    {
        public SaleRepository(SalesManagerDbContext context) : base(context)
        {
        }
    }
}
