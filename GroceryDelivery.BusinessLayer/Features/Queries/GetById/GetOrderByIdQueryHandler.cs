using AutoMapper;
using GroceryDelivery.BusinessLayer.Persistence;
using GroceryDelivery.BusinessLayer.Persistence.Services;
using GroceryDelivery.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GroceryDelivery.BusinessLayer.Features.Queries.GetById
{
    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQuery, List<ProductOrder>>
    {
        private readonly IGroceryServices _groceryServices;
        private readonly IMapper _mapper;

        public GetOrderByIdQueryHandler(IGroceryServices groceryServices, IMapper mapper)
        {
            _groceryServices = groceryServices;
            _mapper = mapper;
        }
        public async Task<List<ProductOrder>> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            var data = await _groceryServices.OrderByuserId(request.UserId);
            return (List<ProductOrder>)data;
        }
    }
}