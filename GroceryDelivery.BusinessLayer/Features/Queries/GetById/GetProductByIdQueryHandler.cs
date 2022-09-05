using AutoMapper;
using GroceryDelivery.BusinessLayer.Persistence;
using GroceryDelivery.BusinessLayer.Persistence.Services;
using GroceryDelivery.Entites;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace GroceryDelivery.BusinessLayer.Features
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly IGroceryServices _groceryServices;
        private readonly IMapper _mapper;

        public GetProductByIdQueryHandler(IGroceryServices groceryServices, IMapper mapper)
        {
            _groceryServices = groceryServices;
            _mapper = mapper;
        }
        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var data = await _groceryServices.GetProductById(request.ProductId);
            var response = _mapper.Map<Product>(data);
            return response;

        }
    }
}
