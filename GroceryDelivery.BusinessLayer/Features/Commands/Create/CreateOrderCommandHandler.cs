using AutoMapper;
using GroceryDelivery.BusinessLayer.Persistence;
using GroceryDelivery.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GroceryDelivery.BusinessLayer.Features.Order.Commands.Create
{
    public class CreateOrderCommandHandler :IRequestHandler<CreateOrderCommand, ApplicationUser>
    {
        private readonly IGroceryRepository _groceryRepository;
        private readonly IMapper _mapper;
        public CreateOrderCommandHandler(IGroceryRepository groceryRepository, IMapper mapper)
        {
            _groceryRepository = groceryRepository;
            _mapper = mapper;
        }

        public async Task<ApplicationUser> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var record = _mapper.Map<ApplicationUser>(request);
            var data = await _groceryRepository.PlaceOrder(record);
            return data;
        }        
    }
}