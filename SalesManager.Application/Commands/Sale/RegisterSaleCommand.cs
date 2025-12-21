using SalesManager.Application.Common.CQRS;

namespace SalesManager.Application.Commands.Sale
{
    public class RegisterSaleCommand : ICommand<Guid>
    {
        public Guid ClientId { get; private set; }
        public List<SaleItemCommand> Items { get; private set; } = new();
        public DateTimeOffset Timestamp => DateTimeOffset.UtcNow;

        public RegisterSaleCommand(Guid clientId, List<SaleItemCommand> items)
        {
            ClientId = clientId;
            Items = items;
        }
    }

    public class SaleItemCommand
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
