using Products_API.DTOs;

namespace Products_API.Services.Interfaces
{
    public interface ISupplierService
    {
        Task<SupplierDTO> GetById(int id);
        Task<IEnumerable<SupplierDTO>> GetByDescription(string description);
        Task<SupplierDTO> Add(SupplierDTO model);
        Task<SupplierDTO> Update(SupplierDTO model);
        Task<SupplierDTO> Delete(int id);
    }
}