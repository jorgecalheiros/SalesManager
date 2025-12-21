using SalesManager.Application.Common.CQRS;
using SalesManager.Domain.Interfaces.Repositories;

namespace SalesManager.Application.Commands.Client.Handlers
{
    public class UpdateClientCommandHandler : ICommandHandler<UpdateClientCommand, bool>
    {
        private readonly IClientRepository _clientRepository;

        public UpdateClientCommandHandler(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<bool> HandleAsync(UpdateClientCommand request, CancellationToken cancellationToken = default)
        {
            try
            {
                var client = await _clientRepository.GetByIdAsync(request.Id, cancellationToken) ?? throw new InvalidOperationException("Cliente não encontrado.");

                await _clientRepository.ExecuteTransactionAsync(async () =>
                {
                    if (!string.IsNullOrWhiteSpace(request.Name))
                    {
                        client.ChangeName(request.Name);
                    }
                    if (!string.IsNullOrWhiteSpace(request.Email))
                    {
                        var emailExists = await _clientRepository.GetByEmailAsync(request.Email, cancellationToken);
                        if (emailExists != null && emailExists.Id != client.Id)
                        {
                            throw new InvalidOperationException("Já existe um cliente com este email.");
                        }

                        client.ChangeEmail(request.Email);
                    }
                    if (!string.IsNullOrWhiteSpace(request.PhoneNumber))
                    {
                        client.ChangePhoneNumber(request.PhoneNumber);
                    }
                    return;
                });

                return true;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocorreu um erro ao atualizar o cliente.", ex);
            }
        }
    }
}
