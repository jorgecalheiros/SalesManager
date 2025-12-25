namespace SalesManager.Domain.Entities
{
    public class Client : Entity
    {
        public string Name { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public string PhoneNumber { get; private set; } = string.Empty;

        public Client(string name, string email, string phoneNumber)
        {
            ChangeName(name);
            ChangeEmail(email);
            ChangePhoneNumber(phoneNumber);
        }

        public void ChangeName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name is required.", nameof(name));

            if (string.Equals(Name, name, StringComparison.Ordinal))
                return;

            Name = name;
            Touch();
        }

        public void ChangeEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentException("Email is required.", nameof(email));

            if (string.Equals(Email, email, StringComparison.OrdinalIgnoreCase))
                return;

            Email = email;
            Touch();
        }

        public void ChangePhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                throw new ArgumentException("Phone number is required.", nameof(phoneNumber));

            if (string.Equals(PhoneNumber, phoneNumber, StringComparison.Ordinal))
                return;

            PhoneNumber = phoneNumber;
            Touch();
        }
    }
}
