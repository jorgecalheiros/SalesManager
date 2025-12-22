using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using SalesManager.Application.Commands.Product;
using SalesManager.Application.Common.SimpleMediator.Interfaces;
using SalesManager.Application.Integration.Tests.Fixture;
using SalesManager.Application.Query.Product;

namespace SalesManager.Application.Integration.Tests
{
    public class ProductTests
    {
        private readonly ApplicationFixture _fixture = new();

        [Fact]
        public async Task CreateProduct_Should_PersistProduct()
        {
            using var scope = _fixture.ServiceProvider.CreateScope();

            var mediator = scope.ServiceProvider.GetRequiredService<IMediator>();

            var command = new CreateProductCommand(
                "Notebook",
                4500m,
                10
            );

            var productId = await mediator.Send(command);

            productId.Should().NotBeEmpty();
        }

        [Fact]
        public async Task GetProductById_Should_ReturnProduct()
        {
            using var scope = _fixture.ServiceProvider.CreateScope();

            var mediator = scope.ServiceProvider.GetRequiredService<IMediator>();

            var productId = await mediator.Send(
                new CreateProductCommand("Mouse", 100m, 50)
            );

            var product = await mediator.Send(new GetProductByIdQuery(productId));

            product.Should().NotBeNull();
            product!.Name.Should().Be("Mouse");
        }

        [Fact]
        public async Task UpdateProduct_Should_UpdateProductData()
        {
            using var scope = _fixture.ServiceProvider.CreateScope();

            var mediator = scope.ServiceProvider.GetRequiredService<IMediator>();

            var productId = await mediator.Send(
                new CreateProductCommand("Teclado", 200m, 30)
            );

            await mediator.Send(
                new UpdateProductCommand(productId, "Teclado Mecanico", 300m, 20)
            );

            var product = await mediator.Send(new GetProductByIdQuery(productId));

            product!.Price.Should().Be(300m);
            product.Stock.Should().Be(20);
        }

        [Fact]
        public async Task DeleteProduct_Should_RemoveProduct()
        {
            using var scope = _fixture.ServiceProvider.CreateScope();

            var mediator = scope.ServiceProvider.GetRequiredService<IMediator>();

            var productId = await mediator.Send(
                new CreateProductCommand("Produto Delete", 10m, 1)
            );

            await mediator.Send(new DeleteProductCommand(productId));

            var productDeleted = await mediator.Send(new GetProductByIdQuery(productId));

            productDeleted.Should().BeNull();
        }
    }
}
