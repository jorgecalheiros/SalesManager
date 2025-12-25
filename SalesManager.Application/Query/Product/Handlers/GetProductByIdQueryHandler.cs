using SalesManager.Application.Common.CQRS;
using SalesManager.Contracts.DTOs;
using SalesManager.Contracts.Interfaces.Repositories;

namespace SalesManager.Application.Query.Product.Handlers
{
    public class GetProductByIdQueryHandler : IQueryHandler<GetProductByIdQuery, ProductDto?>
    {
        private readonly IProductReadRepository _productRepository;

        public GetProductByIdQueryHandler(IProductReadRepository productReadRepository)
        {
            _productRepository = productReadRepository;
        }

        public async Task<ProductDto?> HandleAsync(GetProductByIdQuery request, CancellationToken cancellationToken = default)
        {
            return await _productRepository.GetByIdAsync(request.Id, cancellationToken);
        }
    }
}
