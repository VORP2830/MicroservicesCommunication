using Products_API.Repositories.Interfaces;

namespace Products_API.Repository.Interface
{
    public interface IUnitOfWork
    {
        IProductRepository ProductRepository { get; }
        ICategoryRepository CategoryRepository { get; } 
        ISupplierRepository SupplierRepository { get; }
        Task<bool> SaveChangesAsync();  
    }
}