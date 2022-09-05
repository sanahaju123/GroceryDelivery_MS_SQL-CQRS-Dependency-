using GroceryDelivery.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroceryDelivery.BusinessLayer.Features.Queries.GetById
{
    public class GetOrderByIdQuery : IRequest<ProductOrder>
    {
        public int UserId { get; set; }
    }
}
