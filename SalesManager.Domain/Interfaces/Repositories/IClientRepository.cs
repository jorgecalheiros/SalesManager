namespace SalesManager.Domain.Interfaces.Repositories
{
    public interface IClientRepository : IBaseRepository<Entities.Client>
    {
        Task<Entities.Client?> GetByEmailAsync(string email, CancellationToken cancellationToken = default);
        Task<Entities.Client?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    }
}
