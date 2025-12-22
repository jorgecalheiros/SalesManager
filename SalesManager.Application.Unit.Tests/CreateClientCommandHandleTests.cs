using Moq;
using SalesManager.Application.Commands.Client;
using SalesManager.Application.Commands.Client.Handlers;
using SalesManager.Domain.Interfaces.Repositories;

namespace SalesManager.Application.Unit.Tests
{
    public class CreateClientCommandHandleTests
    {
        [Fact]
        public void CreateClientCommandHandler_Should_ThrowException_When_Found_A_Client_With_Same_Email()
        {
            var mockClientRepository = new Mock<IClientRepository>();
            mockClientRepository
                .Setup(repo => repo.GetByEmailAsync(It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new Domain.Entities.Client("Existing Client", "sameemail@gmail.com", "12345678900"));

            var command = new CreateClientCommandHandler(mockClientRepository.Object);
            var commandRequest = new CreateClientCommand("New Client", "sameemail@gmail.com", "00987654321");

            var ex = Assert.Throws<InvalidOperationException>(() =>
            {
                command.HandleAsync(commandRequest).GetAwaiter().GetResult();
            });

            Assert.Equal("Já existe um cliente com este email.", ex.Message);
        }


    }
}
