namespace SalesManager.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);
        Task ExecuteTransactionAsync(Func<Task> operation, CancellationToken cancellationToken = default);
    }
}
