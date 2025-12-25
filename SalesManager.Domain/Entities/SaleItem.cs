namespace SalesManager.Domain.Entities
{
    public sealed class SaleItem : Entity
    {
        public Guid ProductId { get; }
        public Product Product { get; set; } = null!;
        public decimal UnitPrice { get; }
        public int Quantity { get; }
        public decimal Total => UnitPrice * Quantity;
        public Guid SaleId { get; private set; }
        public Sale? Sale { get; private set; }

        public SaleItem(Guid productId, decimal unitPrice, int quantity, Product product)
        {
            if (productId == Guid.Empty)
                throw new ArgumentException("ProductId must be a valid Guid.", nameof(productId));

            if (unitPrice <= 0m)
                throw new ArgumentException("UnitPrice must be greater than zero.", nameof(unitPrice));

            if (quantity <= 0)
                throw new ArgumentException("Quantity must be greater than zero.", nameof(quantity));

            ProductId = productId;
            UnitPrice = unitPrice;
            Quantity = quantity;
        }

        private SaleItem() { }
    }
}
