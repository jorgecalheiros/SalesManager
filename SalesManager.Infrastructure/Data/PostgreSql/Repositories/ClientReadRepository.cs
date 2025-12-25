using Microsoft.EntityFrameworkCore;
using SalesManager.Contracts.DTOs;
using SalesManager.Contracts.Interfaces.Repositories;

namespace SalesManager.Infrastructure.Data.PostgreSql.Repositories
{
    public class ClientReadRepository : IClientReadRepository
    {
        private readonly IDbContextFactory<SalesManagerDbContext> _contextFactory;

        public ClientReadRepository(IDbContextFactory<SalesManagerDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<IEnumerable<ClientDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            using var context = await _contextFactory.CreateDbContextAsync(cancellationToken);

            return await context.Clients
                .AsNoTracking()
                .Select(c => new ClientDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    Email = c.Email,
                    PhoneNumber = c.PhoneNumber,
                    CreatedAt = c.CreatedAt,
                    UpdatedAt = c.UpdatedAt,
                }).ToListAsync(cancellationToken).ConfigureAwait(false);
        }

        public async Task<ClientDto?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            using var context = await _contextFactory.CreateDbContextAsync(cancellationToken);

            return await context.Clients
                .AsNoTracking()
                .Where(c => c.Id == id)
                .Select(c => new ClientDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    Email = c.Email,
                    PhoneNumber = c.PhoneNumber,
                    CreatedAt = c.CreatedAt,
                    UpdatedAt = c.UpdatedAt
                })
                .SingleOrDefaultAsync(cancellationToken);
        }
    }
}
