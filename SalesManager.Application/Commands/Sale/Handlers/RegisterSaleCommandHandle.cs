using SalesManager.Application.Common.CQRS;
using SalesManager.Domain.Interfaces.Repositories;

namespace SalesManager.Application.Commands.Sale.Handlers
{
    public class RegisterSaleCommandHandle : ICommandHandler<RegisterSaleCommand, Guid>
    {
        private readonly IProductRepository _productRepository;
        private readonly IClientRepository _clientRepository;
        private readonly ISaleRepository _saleRepository;

        public RegisterSaleCommandHandle(IProductRepository productRepository, IClientRepository clientRepository, ISaleRepository saleRepository)
        {
            _productRepository = productRepository;
            _clientRepository = clientRepository;
            _saleRepository = saleRepository;
        }

        public async Task<Guid> HandleAsync(RegisterSaleCommand request, CancellationToken cancellationToken = default)
        {
            try
            {
                var client = await _clientRepository.GetByIdAsync(request.ClientId, cancellationToken);
                if (client == null) throw new InvalidOperationException($"Cliente com ID {request.ClientId} não encontrado.");

                var sale = new Domain.Entities.Sale(request.ClientId);

                await _saleRepository.ExecuteTransactionAsync(async () =>
                {

                    foreach (var item in request.Items)
                    {
                        var product = await _productRepository.GetByIdAsync(item.ProductId, cancellationToken);
                        if (product == null) throw new InvalidOperationException($"Produto com ID {item.ProductId} não encontrado.");

                        sale.AddItem(product, item.Quantity);
                    }

                    _saleRepository.Add(sale);
                }, cancellationToken);

                return sale.Id;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocorreu um erro ao registrar a venda.", ex);
            }
        }
    }
}
