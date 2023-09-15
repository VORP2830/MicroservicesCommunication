using Products_API.Entities;

namespace Products_API.Repositories.Interfaces
{
    public interface ISupplierRepository
    {
        Task<Supplier> GetById(int id);
        Task<IEnumerable<Supplier>> GetByName(string name);
    }
}