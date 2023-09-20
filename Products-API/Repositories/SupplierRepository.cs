using Microsoft.EntityFrameworkCore;
using Products_API.Context;
using Products_API.Entities;
using Products_API.Repositories.Interfaces;

namespace Products_API.Repositories
{
    public class SupplierRepository : Repository<Supplier>, ISupplierRepository
    {
        private readonly ApplicationDbContext _context;
        public SupplierRepository(ApplicationDbContext context) : base(context) { }
        public async Task<Supplier> GetById(int id)
        {
            return await _context.Suppliers.Where(s => s.Id == id).FirstOrDefaultAsync();
        }
        public async Task<IEnumerable<Supplier>> GetByName(string name)
        {
            return await _context.Suppliers.Where(p => p.Name.ToLower().Contains(name.ToLower())).ToListAsync();
        }
    }
}