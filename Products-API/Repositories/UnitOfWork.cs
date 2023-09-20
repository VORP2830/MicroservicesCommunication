using Products_API.Context;
using Products_API.Repositories;
using Products_API.Repositories.Interfaces;
using Products_API.Repository.Interface;

namespace Products_API.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private ProductRepository _productRepository;
        private CategoryRepository _categoryRepository;
        private SupplierRepository _supplierRepository;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
        public IProductRepository ProductRepository
        {
            get
            {
                return _productRepository = _productRepository ?? new ProductRepository(_context);
            }
        }

        public ICategoryRepository CategoryRepository
        {
            get
            {
                return _categoryRepository = _categoryRepository ?? new CategoryRepository(_context);
            }
        }

        public ISupplierRepository SupplierRepository
        {
            get
            {
                return _supplierRepository = _supplierRepository ?? new SupplierRepository(_context);
            }
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}