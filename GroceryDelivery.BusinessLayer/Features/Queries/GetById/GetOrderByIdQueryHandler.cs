using AutoMapper;
using GroceryDelivery.BusinessLayer.Persistence;
using GroceryDelivery.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GroceryDelivery.BusinessLayer.Features.Queries.GetById
{
    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQuery, ProductOrder>
    {
        private readonly IGroceryRepository _groceryRepository;
        private readonly IMapper _mapper;

        public GetOrderByIdQueryHandler(IGroceryRepository groceryRepository, IMapper mapper)
        {
            _groceryRepository = groceryRepository;
            _mapper = mapper;
        }
        public async Task<ProductOrder> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            var data = await _groceryRepository.OrderByuserId(request.UserId);
            return (ProductOrder)data;
        }
    }
}