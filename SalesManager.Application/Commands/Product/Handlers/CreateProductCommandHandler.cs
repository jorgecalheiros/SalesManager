using SalesManager.Application.Common.CQRS;
using SalesManager.Domain.Interfaces.Repositories;

namespace SalesManager.Application.Commands.Product.Handlers
{
    public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, Guid>
    {
        private readonly IProductRepository _productRepository;

        public CreateProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Guid> HandleAsync(CreateProductCommand request, CancellationToken cancellationToken = default)
        {
            try
            {
                var product = new Domain.Entities.Product(request.Name, request.Price, request.Stock, request.Description);

                await _productRepository.ExecuteTransactionAsync(() =>
                {
                    _productRepository.Add(product);
                    return Task.CompletedTask;
                }, cancellationToken);

                return product.Id;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocorreu um erro ao criar o produto.", ex);
            }
        }
    }
}
