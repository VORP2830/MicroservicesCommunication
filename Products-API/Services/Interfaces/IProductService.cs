using Products_API.DTOs;

namespace Products_API.Services.Interfaces
{
    public interface IProductService
    {
        Task<ProductDTO> GetById(int id);
        Task<IEnumerable<ProductDTO>> GetByDescription(string description);
        Task<ProductDTO> Add(ProductDTO model);
        Task<ProductDTO> Update(ProductDTO model);
        Task<ProductDTO> Delete(int id);
    }
}