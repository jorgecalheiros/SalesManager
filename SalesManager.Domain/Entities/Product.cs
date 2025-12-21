namespace SalesManager.Domain.Entities
{
    public class Product : Entity
    {
        public string Name { get; private set; } = string.Empty;
        public string Description { get; private set; } = string.Empty;
        public decimal Price { get; private set; }
        public int Stock { get; private set; }

        public Product(string name, string description, decimal price, int stock)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name is required.", nameof(name));

            if (price <= 0m)
                throw new ArgumentException("Price must be greater than zero.", nameof(price));

            if (stock < 0)
                throw new ArgumentException("Stock must be zero or greater.", nameof(stock));

            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
        }

        public void ChangePrice(decimal price)
        {
            if (price <= 0m)
                throw new InvalidOperationException("Price must be greater than zero.");

            Price = price;
            Touch();
        }

        public void ChangeStock(int stock)
        {
            if (stock < 0)
                throw new InvalidOperationException("Stock must be zero or greater.");

            Stock = stock;
            Touch();
        }

        public void DebitStock(int quantity)
        {
            if (quantity <= 0)
                throw new InvalidOperationException("Quantity to debit must be positive.");

            if (quantity > Stock)
                throw new InvalidOperationException("Insufficient stock to fulfill the operation.");

            Stock -= quantity;
            Touch();
        }
    }
}
