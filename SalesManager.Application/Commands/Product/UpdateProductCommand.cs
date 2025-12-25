using SalesManager.Application.Common.CQRS;

namespace SalesManager.Application.Commands.Product
{
    public class UpdateProductCommand : ICommand<Guid>
    {
        public Guid Id { get; private set; }
        public string? Name { get; private set; }
        public string? Description { get; private set; }
        public decimal? Price { get; private set; }
        public int? Stock { get; private set; }
        public DateTimeOffset Timestamp => DateTimeOffset.UtcNow;

        public UpdateProductCommand(Guid id, string? name = null, decimal? price = null, int? stock = null, string? description = null)
        {
            Id = id;
            Price = price;
            Stock = stock;
            Name = name;
            Description = description;
        }
    }
}
