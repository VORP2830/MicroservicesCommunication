using Microsoft.EntityFrameworkCore;
using Products_API.Context;
using Products_API.Repositories.Interfaces;

namespace Products_API.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
       protected ApplicationDbContext _context;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        } 
    }
}