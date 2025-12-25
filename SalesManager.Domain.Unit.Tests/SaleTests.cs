using SalesManager.Domain.Entities;

namespace SalesManager.Domain.Unit.Tests
{
    public class SaleTests
    {
        [Fact]
        public void Sale_Should_ReturnTotalOf30_When_AddingThreeItemsPriced10()
        {
            var clientId = Guid.NewGuid();
            var sale = new Sale(clientId);
            var product = new Product("Test Product", price: 10m, stock: 10);

            sale.AddItem(product, 1);
            sale.AddItem(product, 1);
            sale.AddItem(product, 1);


            Assert.Equal(3, sale.Items.Count);
            Assert.Equal(30m, sale.Total);
        }
    }
}
