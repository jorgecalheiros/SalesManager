using Microsoft.EntityFrameworkCore;
using SalesManager.Domain.Entities;
using SalesManager.Domain.Interfaces.Repositories;

namespace SalesManager.Infrastructure.Data.PostgreSql.Repositories
{
    public class ClientRepository : BaseRepository<Client>, IClientRepository
    {
        public ClientRepository(SalesManagerDbContext context) : base(context)
        {
        }

        public async Task<Client?> GetByEmailAsync(string email, CancellationToken cancellationToken = default)
        {
            var query = from c in _dbSet
                        where c.Email == email
                        select c;
            return await query.SingleOrDefaultAsync(cancellationToken).ConfigureAwait(false);
        }

        public async Task<Client?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var query = from c in _dbSet
                        where c.Id == id
                        select c;
            return await query.SingleOrDefaultAsync(cancellationToken).ConfigureAwait(false);
        }
    }
}
