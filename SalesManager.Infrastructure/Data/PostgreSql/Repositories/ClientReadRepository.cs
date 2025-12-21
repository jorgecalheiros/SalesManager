using Microsoft.EntityFrameworkCore;
using SalesManager.Contracts.DTOs;
using SalesManager.Contracts.Interfaces.Repositories;

namespace SalesManager.Infrastructure.Data.PostgreSql.Repositories
{
    public class ClientReadRepository : IClientReadRepository
    {
        private readonly SalesManagerDbContext _context;

        public ClientReadRepository(SalesManagerDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ClientDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var query = from c in _context.Clients.AsNoTracking()
                        select new ClientDto
                        {
                            Id = c.Id,
                            Name = c.Name,
                            Email = c.Email,
                            PhoneNumber = c.PhoneNumber,
                            CreatedAt = c.CreatedAt,
                            UpdatedAt = c.UpdatedAt
                        };

            return await query.ToListAsync(cancellationToken);
        }

        public async Task<ClientDto?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var query = from c in _context.Clients.AsNoTracking()
                        where c.Id == id
                        select new ClientDto
                        {
                            Id = c.Id,
                            Name = c.Name,
                            Email = c.Email,
                            PhoneNumber = c.PhoneNumber,
                            CreatedAt = c.CreatedAt,
                            UpdatedAt = c.UpdatedAt
                        };

            return await query.SingleOrDefaultAsync(cancellationToken);
        }
    }
}
