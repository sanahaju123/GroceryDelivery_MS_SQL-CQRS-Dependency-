using GroceryDelivery.BusinessLayer.Persistence;
using GroceryDelivery.DataLayer;
using GroceryDelivery.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryDelivery.BusinessLayer.Repositories
{
    public class GroceryRepository : IGroceryRepository
    {
        private readonly GroceryDbContext _dbContext;
        public GroceryRepository(GroceryDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task<Product> AddProduct(Product product)
        {
            var result = await _dbContext.AddAsync<Product>(product);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<ApplicationUser> PlaceOrder(ApplicationUser user)
        {
            var result = await _dbContext.AddAsync<ApplicationUser>(user);
            await _dbContext.SaveChangesAsync();
            result.Entity.UserId = await _dbContext.ApplicationUsers.MaxAsync(u => u.UserId);
            return result.Entity;
        }

        public async Task<IEnumerable<Product>> GetAllProduct()
        {
            var allProductList = await _dbContext.Products.ToListAsync();
            return allProductList;
        }

        public async Task<Product> GetProductById(int ProductId)
        {
            var data=await _dbContext.Products.FirstOrDefaultAsync(p => p.ProductId == ProductId);
            return data;
        }

        public async Task<IEnumerable<Product>> ProductByName(string name)
        {
            var data= (IEnumerable<Product>)await _dbContext.Products.FirstOrDefaultAsync(p => p.ProductName == name);
            return data;
        }

        public async Task<IList<Menubar>> MenuList()
        {
            var allMenuList = await _dbContext.Menubars.ToListAsync();
            return allMenuList;
        }

        public async Task<IEnumerable<ProductOrder>> OrderByuserId(int UserId)
        {
            var data= await _dbContext.productOrders.Where(p => p.UserId == UserId).ToListAsync();
            return data.ToList();
        }
    }
}
