using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products_API.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}