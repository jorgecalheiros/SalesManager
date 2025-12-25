using SalesManager.Application.Common.CQRS;

namespace SalesManager.Application.Commands.Client
{
    public class CreateClientCommand : ICommand<Guid>
    {
        public string Name { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public string PhoneNumber { get; private set; } = string.Empty;
        public DateTimeOffset Timestamp => DateTimeOffset.UtcNow;

        public CreateClientCommand(string name, string email, string phoneNumber)
        {
            Name = name;
            Email = email;
            PhoneNumber = new string(phoneNumber.Where(char.IsDigit).ToArray());
        }
    }
}
