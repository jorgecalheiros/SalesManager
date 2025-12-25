namespace SalesManager.Domain.Entities
{
    public class Sale : Entity
    {
        public Guid ClientId { get; private set; }
        public Client Client { get; set; } = null!;
        public List<SaleItem> Items { get; private set; } = new();
        public decimal Total => Items.Sum(i => i.Total);

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

            var item = new SaleItem(product.Id, product.Price, quantity, product);
            Items.Add(item);

            Touch();
        }
    }
}
