using SalesManager.Application.Common.CQRS;
using SalesManager.Contracts.DTOs;
using SalesManager.Contracts.Interfaces.Repositories;

namespace SalesManager.Application.Query.Client.Handlers
{
    public class GetClientByIdQueryHandler : IQueryHandler<GetClientByIdQuery, ClientDto?>
    {
        private readonly IClientReadRepository _clientReadRepository;

        public GetClientByIdQueryHandler(IClientReadRepository clientReadRepository)
        {
            _clientReadRepository = clientReadRepository;
        }

        public async Task<ClientDto?> HandleAsync(GetClientByIdQuery request, CancellationToken cancellationToken = default)
        {
            return await _clientReadRepository.GetByIdAsync(request.Id, cancellationToken);
        }
    }
}
