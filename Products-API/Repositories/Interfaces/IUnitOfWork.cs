namespace Products_API.Repository.Interface
{
    public interface IUnitOfWork
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;  
        Task<bool> SaveChangesAsync();  
    }
}