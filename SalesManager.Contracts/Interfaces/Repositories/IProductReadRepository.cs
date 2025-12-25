using SalesManager.Contracts.DTOs;

namespace SalesManager.Contracts.Interfaces.Repositories
{
    public interface IProductReadRepository
    {
        Task<IEnumerable<ProductDto>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<ProductDto?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    }
}
