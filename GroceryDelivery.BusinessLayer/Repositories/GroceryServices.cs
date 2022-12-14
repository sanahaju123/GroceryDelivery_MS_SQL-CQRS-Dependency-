using GroceryDelivery.BusinessLayer.Persistence;
using GroceryDelivery.BusinessLayer.Persistence.Services;
using GroceryDelivery.Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GroceryDelivery.BusinessLayer.Repositories
{
    public class GroceryServices : IGroceryServices
    {
        /// <summary>
        /// Creating Referancce variable of IGroceryRepository
        /// and injecting Referance into constructor
        /// </summary>
        private readonly IGroceryRepository _grocery;
        public GroceryServices(IGroceryRepository groceryRepository)
        {
            _grocery = groceryRepository;
        }
        /// <summary>
        /// Add new product in InMemoryDb
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public async Task<Product> AddProduct(Product product)
        {
            return await _grocery.AddProduct(product);
        }
        /// <summary>
        /// Get All product from Db and using id also
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Product>> GetAllProduct()
        {
            return await _grocery.GetAllProduct();
        }
        /// <summary>
        /// Get Product by Id
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns></returns>
        public async Task<Product> GetProductById(int ProductId)
        {
            return await _grocery.GetProductById(ProductId);
        }
        /// <summary>
        /// get menu list
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Menubar>> MenuList()
        {
            return await _grocery.MenuList();
        }
        /// <summary>
        /// Place order using product order
        /// </summary>
        /// <param name="ProductId"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> PlaceOrder(ApplicationUser user)
        {
            return await _grocery.PlaceOrder(user);
        }
        /// <summary>
        /// Find Product by Product name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Product>> ProductByName(string name)
        {
            return await _grocery.ProductByName(name);
        }

        public async Task<IEnumerable<ProductOrder>> OrderByuserId(int UserId)
        {
            return await _grocery.OrderByuserId(UserId);
        }
    }
}