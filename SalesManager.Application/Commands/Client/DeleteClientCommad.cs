using SalesManager.Application.Common.CQRS;

namespace SalesManager.Application.Commands.Client
{
    public class DeleteClientCommad : ICommand<bool>
    {
        public Guid Id { get; private set; }
        public DateTimeOffset Timestamp => DateTimeOffset.UtcNow;

        public DeleteClientCommad(Guid id)
        {
            Id = id;
        }
    }
}
