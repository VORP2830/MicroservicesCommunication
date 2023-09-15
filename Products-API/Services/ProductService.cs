using AutoMapper;
using Products_API.DTOs;
using Products_API.Entities;
using Products_API.Repositories;
using Products_API.Repository;
using Products_API.Services.Interfaces;

namespace Products_API.Services
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly UnitOfWork _unitOfWork;
        private readonly ProductRepository _productRepository;

        public ProductService(UnitOfWork unitOfWork, IMapper mapper, ProductRepository productRepository)
        {
            _unitOfWork = unitOfWork;
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<ProductDTO> GetById(int id)
        {
            var product = _productRepository.GetById(id);
            return _mapper.Map<ProductDTO>(product);
        }
        public async Task<IEnumerable<ProductDTO>> GetByDescription(string description)
        {
            var product = _productRepository.GetByName(description);
            return _mapper.Map<IEnumerable<ProductDTO>>(product);
        }
        public async Task<ProductDTO> Add(ProductDTO model)
        {
            var product = _mapper.Map<Product>(model);
            _unitOfWork.Add(product);
            _unitOfWork.SaveChangesAsync();
            return model;
        }
        public async Task<ProductDTO> Update(ProductDTO model)
        {
            var product = _mapper.Map<Product>(model);
            _unitOfWork.Update(product);
            _unitOfWork.SaveChangesAsync();
            return model;
        }
        public async Task<ProductDTO> Delete(int id)
        {
            var product = GetById(id);
            if(product == null) return null;
            _unitOfWork.Delete(product);
            _unitOfWork.SaveChangesAsync();
            return _mapper.Map<ProductDTO>(product);
        }
    }
}