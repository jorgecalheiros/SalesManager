using SalesManager.Domain.Entities;

namespace SalesManager.Domain.Unit.Tests
{
    public class ProductTests
    {
        [Fact]
        public void Product_Should_ThrowException_When_StockIsInsufficient()
        {
            var product = new Product("Product", price: 10m, stock: 2);

            var ex = Assert.Throws<InvalidOperationException>(() => product.DebitStock(5));

            Assert.Equal("Insufficient stock to fulfill the operation.", ex.Message);
        }
    }
}
