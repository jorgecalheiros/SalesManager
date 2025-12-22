using FluentAssertions;
using Moq;
using SalesManager.Application.Commands.Sale;
using SalesManager.Application.Commands.Sale.Handlers;
using SalesManager.Domain.Entities;
using SalesManager.Domain.Interfaces.Repositories;

namespace SalesManager.Application.Unit.Tests
{
    public class RegisterSaleCommandHandleTests
    {
        private readonly Mock<IProductRepository> _productRepoMock;
        private readonly Mock<IClientRepository> _clientRepoMock;
        private readonly Mock<ISaleRepository> _saleRepoMock;
        private readonly RegisterSaleCommandHandler _handler;

        public RegisterSaleCommandHandleTests()
        {
            _productRepoMock = new Mock<IProductRepository>();
            _clientRepoMock = new Mock<IClientRepository>();
            _saleRepoMock = new Mock<ISaleRepository>();

            _handler = new RegisterSaleCommandHandler(
                _productRepoMock.Object,
                _clientRepoMock.Object,
                _saleRepoMock.Object);

            _saleRepoMock
                .Setup(x => x.ExecuteTransactionAsync(It.IsAny<Func<Task>>(), It.IsAny<CancellationToken>()))
                .Callback<Func<Task>, CancellationToken>(async (action, token) => await action())
                .Returns(Task.CompletedTask);
        }

        [Fact]
        public async Task RegisterSale_Should_ReturnGuid_When_SaleIsRegisteredSuccessfully()
        {
            var client = new Client("name", "email@email", "551999999");
            var product = new Product("product", 19.5m, 5);
            var command = new RegisterSaleCommand(client.Id, new List<SaleItemCommand> { new SaleItemCommand { ProductId = product.Id, Quantity = 5 } });

            _clientRepoMock.Setup(x => x.GetByIdAsync(client.Id, It.IsAny<CancellationToken>()))
                .ReturnsAsync(client);

            _productRepoMock.Setup(x => x.GetByIdAsync(product.Id, It.IsAny<CancellationToken>()))
                .ReturnsAsync(product);

            var result = await _handler.HandleAsync(command);

            result.Should().NotBeEmpty();
            _saleRepoMock.Verify(x => x.Add(It.IsAny<Sale>()), Times.Once);
        }

        [Fact]
        public async Task RegisterSale_Should_ThrowApplicationException_When_ClientDoesNotExist()
        {
            var clientId = Guid.NewGuid();
            var command = new RegisterSaleCommand(clientId, new List<SaleItemCommand>());

            _clientRepoMock.Setup(x => x.GetByIdAsync(clientId, It.IsAny<CancellationToken>()))
                .ReturnsAsync((Client?)null);

            Func<Task> act = async () => await _handler.HandleAsync(command);

            await act.Should().ThrowAsync<InvalidOperationException>()
                .WithMessage($"*Cliente com ID {clientId} não encontrado.*");
        }

        [Fact]
        public async Task RegisterSale_Should_ThrowApplicationException_When_ProductDoesNotExist()
        {
            var client = new Client("name", "email@email", "551999999");
            var productId = Guid.NewGuid();
            var command = new RegisterSaleCommand(client.Id, new List<SaleItemCommand> { new SaleItemCommand { ProductId = productId, Quantity = 1 } });

            _clientRepoMock.Setup(x => x.GetByIdAsync(client.Id, It.IsAny<CancellationToken>()))
                .ReturnsAsync(client);

            _productRepoMock.Setup(x => x.GetByIdAsync(productId, It.IsAny<CancellationToken>()))
                .ReturnsAsync((Product?)null);

            _saleRepoMock
                .Setup(x => x.ExecuteTransactionAsync(It.IsAny<Func<Task>>(), It.IsAny<CancellationToken>()))
                .Callback<Func<Task>, CancellationToken>(async (action, token) => await action())
                .ThrowsAsync(new InvalidOperationException($"Produto com ID {productId} não encontrado."));

            Func<Task> act = async () => await _handler.HandleAsync(command);

            await act.Should().ThrowAsync<InvalidOperationException>()
                .WithMessage($"Produto com ID {productId} não encontrado.");
        }
    }
}
