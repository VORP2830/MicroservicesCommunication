using Products_API.Entities;

namespace Products_API.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        Task<Category> GetById(int id);
        Task<IEnumerable<Category>> GetByDescription(string description);
        
    }
}