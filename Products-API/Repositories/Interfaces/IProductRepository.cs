using Products_API.Entities;

namespace Products_API.Repositories.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product> GetById(int id);
        Task<IEnumerable<Product>> GetByName(string name);

    }
}