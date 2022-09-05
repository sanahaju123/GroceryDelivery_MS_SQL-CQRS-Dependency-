using GroceryDelivery.Entites;
using MediatR;

namespace GroceryDelivery.BusinessLayer.Features
{
    public class GetProductByIdQuery : IRequest<Product>
    {
        public int ProductId { get; set; }
    }
}
