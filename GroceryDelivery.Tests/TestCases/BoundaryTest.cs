
using GroceryDelivery.Entites;
using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Grocerydelivery.Tests.TestCases
{
    public class BoundaryTests
    {
        /// <summary>
        /// Creating Referance Variable of Service Interface and Mocking Repository Interface and class
        /// </summary>
        private readonly ITestOutputHelper _output;
        private readonly Product _product;
        private readonly Menubar _menubar;
        private readonly ApplicationUser _user;
        private readonly ProductOrder _order;
        private static string type = "Functional";

        public BoundaryTests(ITestOutputHelper output)
        {
            //Creating New mock Object with value.
            _output = output;

            _product = new Product
            {
                ProductId = 2,
                ProductName = "Samsung - TV",
                Description = "Size - 72, SSD-128 GB, Processor-Snap Dragon 805, Screen - 4500X3000PX",
                Amount = 12990,
                stock = 13,
                CatId = 2
            };
            _menubar = new Menubar
            {
                Id = 1,
                Title = "Home",
                Url = "~/",
                OpenInNewWindow = false
            };
            _user = new ApplicationUser()
            {
                UserId = 2,
                Name = "Name1",
                Email = "namelast@gmail.com",
                MobileNumber = 9631438113,
                PinCode = 823311,
                HouseNo_Building_Name = "9/11",
                Road_area = "Manpur Gaya",
                City = "Gaya",
                State = "Bihar"
            };
            _order = new ProductOrder()
            {
                OrderId = 1,
                ProductId = 1,
                UserId = 1
            };
        }


    }
}
