using GroceryDelivery.Entites;
using MediatR;
using System.Collections.Generic;

namespace GroceryDelivery.BusinessLayer.Features
{
    public class ProductQuery : IRequest<List<Product>>
    {
    }
}
