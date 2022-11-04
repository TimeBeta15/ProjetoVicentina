namespace domain.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        void Add(T entity);

        Task<IEnumerable<T>> GetAll();

        void Update(T entity);

        void Delete(T entity);

        Task<T> GetById(string id);
        
        Task<bool> SaveChangesAsync();
    }
}
