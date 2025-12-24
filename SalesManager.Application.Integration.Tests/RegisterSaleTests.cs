using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SalesManager.Application.Commands.Sale;
using SalesManager.Application.Common.SimpleMediator.Interfaces;
using SalesManager.Application.Integration.Tests.Fixture;
using SalesManager.Domain.Entities;

namespace SalesManager.Application.Integration.Tests
{
    public class RegisterSaleTests
    {
        private readonly ApplicationFixture _fixture = new();

        public RegisterSaleTests()
        {
        }

        [Fact]
        public async Task RegisterSale_Should_ProcessEntirePipeline_When_CommandIsSent()
        {
            var mediator = _fixture.ServiceProvider.GetRequiredService<IMediator>();

            var client = new Domain.Entities.Client("frontEndUser", "front@end.com", "559999999");
            var product = new Domain.Entities.Product("Product A", 10.0m, 10);

            using var context = _fixture.CreateContext();
            context.Clients.Add(client);
            context.Products.Add(product);
            await context.SaveChangesAsync();

            var command = new RegisterSaleCommand(client.Id, new List<SaleItemCommand> { new SaleItemCommand { ProductId = product.Id, Quantity = 1, UnitPrice = product.Price } });
            var result = await mediator.SendAsync(command);

            result.Should().NotBeEmpty();
            var saleInDb = await context.Sales.FindAsync(result);
            var productInDb = await context.Products.FindAsync(product.Id);
            productInDb?.Stock.Should().Be(9);
            saleInDb.Should().NotBeNull();
        }

        [Fact]
        public async Task RegisterSale_Should_RollbackAllChanges_When_AnyItemFailsDuringTransaction()
        {
            using var context = _fixture.CreateContext();
            var mediator = _fixture.ServiceProvider.GetRequiredService<IMediator>();

            var client = new Client("Test Client", "teste@gmail.com", "551999999");

            var productOk = new Product("Product Ok", 10, 100);

            var productFail = new Product("Product Fail", 10, 0);

            context.Clients.Add(client);
            context.Products.AddRange(productOk, productFail);
            await context.SaveChangesAsync();

            var command = new RegisterSaleCommand(client.Id, new List<SaleItemCommand>
            {
                new SaleItemCommand { ProductId = productOk.Id, Quantity = 10, UnitPrice = productOk.Price },
                new SaleItemCommand { ProductId = productFail.Id, Quantity = 5, UnitPrice = productFail.Price }
            });


            Func<Task> act = async () => await mediator.SendAsync(command);

            await act.Should().ThrowAsync<InvalidOperationException>();

            using var assertContext = _fixture.CreateContext();

            var saleExists = await assertContext.Sales.AnyAsync(s => s.ClientId == client.Id);
            saleExists.Should().BeFalse();

            var pOkInDb = await assertContext.Products.AsNoTracking().FirstOrDefaultAsync(p => p.Id == productOk.Id);
            pOkInDb!.Stock.Should().Be(100, "o débito de estoque deveria ter sido desfeito pelo rollback");
        }

        [Fact]
        public async Task RegisterSale_Should_ThrowInvalidOperationException_When_ClientDoesNotExist()
        {
            var command = new RegisterSaleCommand(Guid.NewGuid(), new List<SaleItemCommand>() { new SaleItemCommand { ProductId = Guid.NewGuid(), Quantity = 10, UnitPrice = 20 } });

            var mediator = _fixture.ServiceProvider.GetRequiredService<IMediator>();

            Func<Task> act = async () => await mediator.SendAsync(command);

            await act.Should().ThrowAsync<InvalidOperationException>()
                .WithMessage($"*Cliente com ID {command.ClientId} não encontrado.*");
        }
    }
}
