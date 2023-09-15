using Microsoft.EntityFrameworkCore;
using Products_API.Context;
using Products_API.Entities;
using Products_API.Repositories.Interfaces;

namespace Products_API.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Product> GetById(int id)
        {
            return await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync();
        }
        public async Task<IEnumerable<Product>> GetByName(string name)
        {
            return await _context.Products.Where(p => p.Name.ToLower().Contains(name.ToLower())).ToListAsync();
        }
    }
}