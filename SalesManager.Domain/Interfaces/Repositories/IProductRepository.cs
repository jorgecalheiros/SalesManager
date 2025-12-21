using System;
using System.Threading;
using System.Threading.Tasks;

namespace SalesManager.Domain.Interfaces.Repositories
{
    public interface IProductRepository : IBaseRepository<Entities.Product>
    {
        Task<Entities.Product?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    }
}
