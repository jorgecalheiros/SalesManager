using SalesManager.Application.Common.CQRS;

namespace SalesManager.Application.Commands.Product
{
    public class DeleteProductCommand : ICommand<Guid>
    {
        public Guid Id { get; private set; }
        public DateTimeOffset Timestamp => DateTimeOffset.UtcNow;

        public DeleteProductCommand(Guid id)
        {
            Id = id;
        }
    }
}
