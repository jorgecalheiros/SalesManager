using SalesManager.Application.Common.CQRS;
using SalesManager.Domain.Interfaces.Repositories;

namespace SalesManager.Application.Commands.Product.Handlers
{
    public class DeleteProductCommandHandler : ICommandHandler<DeleteProductCommand, Guid>
    {
        private readonly IProductRepository _productRepository;

        public DeleteProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Guid> HandleAsync(DeleteProductCommand request, CancellationToken cancellationToken = default)
        {
            try
            {
                var product = await _productRepository.GetByIdAsync(request.Id, cancellationToken);
                if (product == null)
                    throw new InvalidOperationException("Produto não encontrado.");

                await _productRepository.ExecuteTransactionAsync(() =>
                {
                    _productRepository.Remove(product);
                    return Task.CompletedTask;
                }, cancellationToken);

                return product.Id;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocorreu um erro ao excluir o produto.", ex);
            }
        }
    }
}
