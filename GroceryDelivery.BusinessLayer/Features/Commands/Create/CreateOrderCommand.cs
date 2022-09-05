
using GroceryDelivery.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace GroceryDelivery.BusinessLayer.Features.Order.Commands.Create
{
    public class CreateOrderCommand : IRequest<ApplicationUser>
    {
       
        public int UserId { get; set; }
        public string Name { get; set; }
        
        public string Email { get; set; }
       
        public long MobileNumber { get; set; }
        
        public long PinCode { get; set; }
       
        public string HouseNo_Building_Name { get; set; }
        
        public string Road_area { get; set; }
        
        public string City { get; set; }
       
        public string State { get; set; }
    }
}
