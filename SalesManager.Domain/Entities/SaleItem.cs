using System;

namespace SalesManager.Domain.Entities
{
    public sealed class SaleItem
    {
        public Guid ProductId { get; }
        public decimal UnitPrice { get; }
        public int Quantity { get; }
        public decimal Total => UnitPrice * Quantity;

        public SaleItem(Guid productId, decimal unitPrice, int quantity)
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
    }
}
