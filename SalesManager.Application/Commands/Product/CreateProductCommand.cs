using SalesManager.Application.Common.CQRS;

namespace SalesManager.Application.Commands.Product
{
    public class CreateProductCommand : ICommand<Guid>
    {
        public string Name { get; private set; } = string.Empty;
        public string Description { get; private set; } = string.Empty;
        public decimal Price { get; private set; }
        public int Stock { get; private set; }
        public DateTimeOffset Timestamp => DateTimeOffset.UtcNow;

        public CreateProductCommand(string name, string description, decimal price, int stock)
        {
            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
        }
    }
}
