using AutoMapper;
using GroceryDelivery.BusinessLayer.Persistence;
using GroceryDelivery.Entites;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GroceryDelivery.BusinessLayer.Features
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly IGroceryRepository _groceryRepository;
        private readonly IMapper _mapper;

        public GetProductByIdQueryHandler(IGroceryRepository groceryRepository, IMapper mapper)
        {
            _groceryRepository = groceryRepository;
            _mapper = mapper;
        }
        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var data = await _groceryRepository.GetProductById(request.ProductId);
            var response = _mapper.Map<Product>(data);
            return response;

        }
    }
}
