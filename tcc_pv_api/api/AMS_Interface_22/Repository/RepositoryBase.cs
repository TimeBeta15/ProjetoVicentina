using AMS_Interface_22.Interfaces;

namespace AMS_Interface_22.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public Task<T> Add(T entity)
        {
            // context.Add(entity); 
            return null;
        }

        public Task<T> GetAll()
        {
            // context.Find();
            return null;
        }
    }
}