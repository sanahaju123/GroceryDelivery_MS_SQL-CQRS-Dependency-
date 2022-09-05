using AutoMapper;
using GroceryDelivery.BusinessLayer.Persistence;
using GroceryDelivery.Entites;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GroceryDelivery.BusinessLayer.Features
{

    public class ProductQueryHandler : IRequestHandler<ProductQuery, List<Product>>
    {
        private readonly IGroceryRepository _groceryRepository;
        private readonly IMapper _mapper;

        public ProductQueryHandler(IGroceryRepository groceryRepository, IMapper mapper)
        {
            _groceryRepository = groceryRepository;
            _mapper = mapper;
        }
        public async Task<List<Product>> Handle(ProductQuery request, CancellationToken cancellationToken)
        {
            var data = await _groceryRepository.GetAllProduct();
            return (List<Product>)data;

        }
    }

}
