using SalesManager.Application.Common.CQRS;
using SalesManager.Contracts.DTOs;
using SalesManager.Contracts.Interfaces.Repositories;


namespace SalesManager.Application.Query.Product.Handlers
{
    public class GetAllProductsQueryHandler : IQueryHandler<GetAllProductsQuery, List<ProductDto>>
    {
        private readonly IProductReadRepository _productRepository;

        public GetAllProductsQueryHandler(IProductReadRepository productReadRepository)
        {
            _productRepository = productReadRepository;
        }

        public async Task<List<ProductDto>> HandleAsync(GetAllProductsQuery request, CancellationToken cancellationToken = default)
        {
            return (await _productRepository.GetAllAsync(cancellationToken)).ToList();
        }
    }
}
