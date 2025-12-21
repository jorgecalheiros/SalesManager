using SalesManager.Application.Common.CQRS;
using SalesManager.Domain.Interfaces.Repositories;

namespace SalesManager.Application.Commands.Product.Handlers
{
    public class UpdateProductCommandHandler : ICommandHandler<UpdateProductCommand, Guid>
    {
        private readonly IProductRepository _productRepository;

        public UpdateProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Guid> HandleAsync(UpdateProductCommand request, CancellationToken cancellationToken = default)
        {
            try
            {
                var product = await _productRepository.GetByIdAsync(request.Id, cancellationToken);
                if (product == null)
                    throw new InvalidOperationException("Produto não encontrado.");

                await _productRepository.ExecuteTransactionAsync(() =>
                {
                    if (!string.IsNullOrEmpty(request.Name))
                        product.ChangeName(request.Name);

                    if (!string.IsNullOrEmpty(request.Description))
                        product.ChangeDescription(request.Description);

                    if (request.Price.HasValue)
                        product.ChangePrice(request.Price.Value);

                    if (request.Stock.HasValue)
                        product.ChangeStock(request.Stock.Value);

                    return Task.CompletedTask;
                }, cancellationToken);

                return product.Id;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocorreu um erro ao atualizar o produto.", ex);
            }
        }
    }
}
