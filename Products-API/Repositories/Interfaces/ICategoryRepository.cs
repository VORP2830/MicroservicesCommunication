using Products_API.DTOs;
using Products_API.Entities;

namespace Products_API.Repositories.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<Category> GetById(int id);
        Task<IEnumerable<Category>> GetByDescription(string description);
    }
}