using SalesManager.Contracts.DTOs;

namespace SalesManager.Contracts.Interfaces.Repositories
{
    public interface IClientReadRepository
    {
        Task<IEnumerable<ClientDto>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<ClientDto?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    }
}
