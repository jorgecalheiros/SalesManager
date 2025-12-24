using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using SalesManager.Application.Commands.Client;
using SalesManager.Application.Common.SimpleMediator.Interfaces;
using SalesManager.Application.Integration.Tests.Fixture;
using SalesManager.Application.Query.Client;

namespace SalesManager.Application.Integration.Tests
{
    public class ClientTests
    {
        private readonly ApplicationFixture _fixture = new();

        [Fact]
        public async Task CreateClient_Should_PersistClientInDatabase()
        {
            using var scope = _fixture.ServiceProvider.CreateScope();

            var mediator = scope.ServiceProvider.GetRequiredService<IMediator>();

            var command = new CreateClientCommand(
                "João Silva",
                "joao@email.com",
                "551199999999"
            );

            var clientId = await mediator.SendAsync(command);

            clientId.Should().NotBeEmpty();
        }

        [Fact]
        public async Task GetClientById_Should_ReturnPersistedClient()
        {
            using var scope = _fixture.ServiceProvider.CreateScope();

            var mediator = scope.ServiceProvider.GetRequiredService<IMediator>();

            var createCommand = new CreateClientCommand(
                "Maria Souza",
                "maria@email.com",
                "551188888888"
            );

            var clientId = await mediator.SendAsync(createCommand);

            var query = new GetClientByIdQuery(clientId);
            var client = await mediator.SendAsync(query);

            client.Should().NotBeNull();
            client!.Name.Should().Be("Maria Souza");
        }

        [Fact]
        public async Task UpdateClient_Should_UpdateClientData()
        {
            using var scope = _fixture.ServiceProvider.CreateScope();

            var mediator = scope.ServiceProvider.GetRequiredService<IMediator>();

            var clientId = await mediator.SendAsync(
                new CreateClientCommand("Carlos", "c@email.com", "551188888888")
            );

            var updateCommand = new UpdateClientCommand(
                clientId,
                "Carlos Atualizado",
                "novo@email.com",
                "551188888889"
            );

            await mediator.SendAsync(updateCommand);

            var client = await mediator.SendAsync(new GetClientByIdQuery(clientId));

            client!.Name.Should().Be("Carlos Atualizado");
            client.Email.Should().Be("novo@email.com");
        }

        [Fact]
        public async Task DeleteClient_Should_RemoveClientFromDatabase()
        {
            using var scope = _fixture.ServiceProvider.CreateScope();

            var mediator = scope.ServiceProvider.GetRequiredService<IMediator>();

            var clientId = await mediator.SendAsync(
                new CreateClientCommand("Delete Me", "del@email.com", "551155555555")
            );

            await mediator.SendAsync(new DeleteClientCommand(clientId));

            var clientDeleted = await mediator.SendAsync(new GetClientByIdQuery(clientId));

            clientDeleted.Should().BeNull();
        }
    }
}
