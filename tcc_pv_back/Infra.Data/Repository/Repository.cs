using domain.Interfaces;
using Infra.Data.Context;

namespace Infra.Data.Repository
{

    public class Repository<T> : IBaseRepository<T> where T : class
    {
        private readonly DataContext context;
        
        public Repository(DataContext context)
        {
            this.context = context;
        }

        public void Add(T entity)
        {
            this.context.Add(entity);
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
