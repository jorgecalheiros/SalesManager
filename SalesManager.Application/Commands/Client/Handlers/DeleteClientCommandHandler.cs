using SalesManager.Application.Common.CQRS;
using SalesManager.Domain.Interfaces.Repositories;

namespace SalesManager.Application.Commands.Client.Handlers
{
    public class DeleteClientCommandHandler : ICommandHandler<DeleteClientCommand, bool>
    {
        private readonly IClientRepository _clientRepository;

        public DeleteClientCommandHandler(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<bool> HandleAsync(DeleteClientCommand request, CancellationToken cancellationToken = default)
        {
            try
            {
                var client = _clientRepository.GetByIdAsync(request.Id, cancellationToken).Result ?? throw new InvalidOperationException("Cliente não encontrado.");

                await _clientRepository.ExecuteTransactionAsync(() =>
                {
                    _clientRepository.Remove(client);
                    return Task.CompletedTask;
                });

                return true;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocorreu um erro ao deletar o cliente.", ex);
            }
        }
    }
}
