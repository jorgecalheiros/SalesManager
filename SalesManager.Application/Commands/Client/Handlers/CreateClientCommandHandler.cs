using SalesManager.Application.Common.CQRS;
using SalesManager.Domain.Interfaces.Repositories;

namespace SalesManager.Application.Commands.Client.Handlers
{
    public class CreateClientCommandHandler : ICommandHandler<CreateClientCommand, Guid>
    {
        private readonly IClientRepository _clientRepository;

        public CreateClientCommandHandler(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<Guid> HandleAsync(CreateClientCommand request, CancellationToken cancellationToken = default)
        {
            try
            {
                var emailExists = await _clientRepository.GetByEmailAsync(request.Email, cancellationToken);
                if (emailExists != null)
                {
                    throw new InvalidOperationException("Já existe um cliente com este email.");
                }

                var client = new Domain.Entities.Client(request.Name, request.Email, request.PhoneNumber);

                await _clientRepository.ExecuteTransactionAsync(() =>
                {
                    _clientRepository.Add(client);
                    return Task.CompletedTask;
                });

                return client.Id;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocorreu um erro ao criar o cliente.", ex);
            }
        }
    }
}
