using GroceryDelivery.Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GroceryDelivery.BusinessLayer.Persistence.Services
{
    public interface IGroceryServices
    {
        Task<Product> AddProduct(Product product);
        Task<ApplicationUser> PlaceOrder(ApplicationUser user);
        Task<IEnumerable<Product>> GetAllProduct();
        Task<Product> GetProductById(int ProductId);
        Task<IEnumerable<Product>> ProductByName(string name);
        Task<IList<Menubar>> MenuList();
        Task<IEnumerable<ProductOrder>> OrderByuserId(int UserId);
    }
}