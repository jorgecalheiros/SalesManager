using SalesManager.Application.Common.CQRS;

namespace SalesManager.Application.Commands.Client
{
    public class UpdateClientCommand : ICommand<bool>
    {
        public Guid Id { get; private set; }
        public string? Name { get; private set; } = null;
        public string? Email { get; private set; } = null;
        public string? PhoneNumber { get; private set; } = null;
        public DateTimeOffset Timestamp => DateTimeOffset.UtcNow;

        public UpdateClientCommand(Guid id, string? name = null, string? email = null, string? phoneNumber = null)
        {
            Id = id;
            Name = name;
            Email = email;
            PhoneNumber = new string(phoneNumber?.Where(char.IsDigit).ToArray());
        }
    }
}
