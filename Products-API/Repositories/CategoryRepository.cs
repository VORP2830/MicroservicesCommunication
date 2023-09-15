using Microsoft.EntityFrameworkCore;
using Products_API.Context;
using Products_API.Entities;
using Products_API.Repositories.Interfaces;

namespace Products_API.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;    
        }
        public async Task<Category> GetById(int id)
        {
            return await _context.Categories.Where(c => c.Id == id).FirstOrDefaultAsync();
        }
        public async Task<IEnumerable<Category>> GetByDescription(string description)
        {
            return await _context.Categories.Where(c => c.Description.ToLower().Contains(description.ToLower())).ToListAsync();
        }
    }
}