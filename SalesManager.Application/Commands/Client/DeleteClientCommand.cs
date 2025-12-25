using SalesManager.Application.Common.CQRS;

namespace SalesManager.Application.Commands.Client
{
    public class DeleteClientCommand : ICommand<bool>
    {
        public Guid Id { get; private set; }
        public DateTimeOffset Timestamp => DateTimeOffset.UtcNow;

        public DeleteClientCommand(Guid id)
        {
            Id = id;
        }
    }
}
