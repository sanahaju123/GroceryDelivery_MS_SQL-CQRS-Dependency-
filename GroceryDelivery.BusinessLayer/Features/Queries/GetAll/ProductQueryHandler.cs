using AutoMapper;
using GroceryDelivery.BusinessLayer.Persistence;
using GroceryDelivery.Entites;
using MediatR;
using GroceryDelivery.BusinessLayer.Persistence.Services;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GroceryDelivery.BusinessLayer.Features
{

    public class ProductQueryHandler : IRequestHandler<ProductQuery, List<Product>>
    {
        private readonly IGroceryServices _groceryServices;
        private readonly IMapper _mapper;

        public ProductQueryHandler(IGroceryServices groceryServices, IMapper mapper)
        {
            _groceryServices = groceryServices;
            _mapper = mapper;
        }
        public async Task<List<Product>> Handle(ProductQuery request, CancellationToken cancellationToken)
        {
            var data = await _groceryServices.GetAllProduct();
            return (List<Product>)data;

        }
    }

}
