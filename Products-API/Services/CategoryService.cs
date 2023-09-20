using AutoMapper;
using Products_API.DTOs;
using Products_API.Entities;
using Products_API.Repositories;
using Products_API.Repository;
using Products_API.Repository.Interface;
using Products_API.Services.Interfaces;

namespace Products_API.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly CategoryRepository _categoryRepository;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper, CategoryRepository categoryRepository)
        {
            _unitOfWork = unitOfWork;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task<CategoryDTO> GetById(int id)
        {
            var category = _categoryRepository.GetById(id);
            return _mapper.Map<CategoryDTO>(category);
        }
        public async Task<IEnumerable<CategoryDTO>> GetByDescription(string description)
        {
            var category = _categoryRepository.GetByDescription(description);
            return _mapper.Map<IEnumerable<CategoryDTO>>(category);
        }
        public async Task<CategoryDTO> Add(CategoryDTO model)
        {
            var category = _mapper.Map<Category>(model);
            _unitOfWork.CategoryRepository.Add(category);
            _unitOfWork.SaveChangesAsync();
            return model;
        }
        public async Task<CategoryDTO> Update(CategoryDTO model)
        {
            var category = _mapper.Map<Category>(model);
            _unitOfWork.CategoryRepository.Update(category);
            _unitOfWork.SaveChangesAsync();
            return model;
        }
        public async Task<CategoryDTO> Delete(int id)
        {
            var category = await _unitOfWork.CategoryRepository.GetById(id);
            if(category == null) return null;
            _unitOfWork.CategoryRepository.Delete(category);
            _unitOfWork.SaveChangesAsync();
            return _mapper.Map<CategoryDTO>(category);
        }
    }
}