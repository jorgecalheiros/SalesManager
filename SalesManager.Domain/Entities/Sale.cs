namespace SalesManager.Domain.Entities
{
    public class Sale : Entity
    {
        private readonly List<SaleItem> _items = new();
        public Guid ClientId { get; private set; }
        public IReadOnlyCollection<SaleItem> Items => _items.AsReadOnly();
        public decimal Total => _items.Sum(i => i.Total);

        public Sale(Guid clientId)
        {
            if (clientId == Guid.Empty)
                throw new ArgumentException("ClientId must be a valid Guid.", nameof(clientId));

            ClientId = clientId;
        }

        public void AddItem(Product product, int quantity)
        {
            if (product is null)
                throw new ArgumentNullException(nameof(product));

            if (quantity <= 0)
                throw new ArgumentException("Quantity must be greater than zero.", nameof(quantity));

            product.DebitStock(quantity);

            var item = new SaleItem(product.Id, product.Price, quantity);
            _items.Add(item);

            Touch();
        }
    }
}
