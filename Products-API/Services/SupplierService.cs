using AutoMapper;
using Products_API.DTOs;
using Products_API.Entities;
using Products_API.Repositories;
using Products_API.Repository;
using Products_API.Services.Interfaces;

namespace Products_API.Services 
{
    public class SupplierService : ISupplierService
    {
        private readonly IMapper _mapper;
        private readonly UnitOfWork _unitOfWork;
        private readonly SupplierRepository _supplierRepository;

        public SupplierService(UnitOfWork unitOfWork, IMapper mapper, SupplierRepository supplierRepository)
        {
            _unitOfWork = unitOfWork;
            _supplierRepository = supplierRepository;
            _mapper = mapper;
        }
        public async Task<SupplierDTO> GetById(int id)
        {
            var supplier = _supplierRepository.GetById(id);
            return _mapper.Map<SupplierDTO>(supplier);
        }
        public async Task<IEnumerable<SupplierDTO>> GetByDescription(string description)
        {
            var supplier = _supplierRepository.GetByName(description);
            return _mapper.Map<IEnumerable<SupplierDTO>>(supplier);
        }
        public async Task<SupplierDTO> Add(SupplierDTO model)
        {
            var supplier = _mapper.Map<Supplier>(model);
            _unitOfWork.Add(supplier);
            _unitOfWork.SaveChangesAsync();
            return model;
        }
        public async Task<SupplierDTO> Update(SupplierDTO model)
        {
            var supplier = _mapper.Map<Supplier>(model);
            _unitOfWork.Update(supplier);
            _unitOfWork.SaveChangesAsync();
            return model;
        }
        public async Task<SupplierDTO> Delete(int id)
        {
            var supplier = GetById(id);
            if(supplier == null) return null;
            _unitOfWork.Delete(supplier);
            _unitOfWork.SaveChangesAsync();
            return _mapper.Map<SupplierDTO>(supplier);
        }
    }
}