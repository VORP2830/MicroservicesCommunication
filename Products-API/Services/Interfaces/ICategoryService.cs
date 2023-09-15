using Products_API.DTOs;

namespace Products_API.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<CategoryDTO> GetById(int id);
        Task<IEnumerable<CategoryDTO>> GetByDescription(string description);
        Task<CategoryDTO> Add(CategoryDTO model);
        Task<CategoryDTO> Update(CategoryDTO model);
        Task<CategoryDTO> Delete(int id);
    }
}