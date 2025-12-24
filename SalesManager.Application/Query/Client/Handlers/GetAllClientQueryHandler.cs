using SalesManager.Application.Common.CQRS;
using SalesManager.Contracts.DTOs;
using SalesManager.Contracts.Interfaces.Repositories;
namespace SalesManager.Application.Query.Client.Handlers
{
    public class GetAllClientQueryHandler : IQueryHandler<GetAllClientQuery, List<ClientDto>>
    {
        private readonly IClientReadRepository _clientReadRepository;
        public GetAllClientQueryHandler(IClientReadRepository clientReadRepository)
        {
            _clientReadRepository = clientReadRepository;
        }

        public async Task<List<ClientDto>> HandleAsync(GetAllClientQuery request, CancellationToken cancellationToken = default)
        {
            return (await _clientReadRepository.GetAllAsync(cancellationToken)).ToList();
        }
    }
}
