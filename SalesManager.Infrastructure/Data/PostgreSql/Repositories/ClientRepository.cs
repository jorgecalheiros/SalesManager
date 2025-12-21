using SalesManager.Domain.Entities;
using SalesManager.Domain.Interfaces.Repositories;

namespace SalesManager.Infrastructure.Data.PostgreSql.Repositories
{
    public class ClientRepository : BaseRepository<Client>, IClientRepository
    {
        public ClientRepository(SalesManagerDbContext context) : base(context)
        {
        }
    }
}
