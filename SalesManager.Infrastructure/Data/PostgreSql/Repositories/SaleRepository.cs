using Microsoft.EntityFrameworkCore;
using SalesManager.Domain.Entities;
using SalesManager.Domain.Interfaces.Repositories;

namespace SalesManager.Infrastructure.Data.PostgreSql.Repositories
{
    public class SaleRepository : BaseRepository<Sale>, ISaleRepository
    {
        public SaleRepository(IDbContextFactory<SalesManagerDbContext> contextFactory) : base(contextFactory)
        {
        }
    }
}
