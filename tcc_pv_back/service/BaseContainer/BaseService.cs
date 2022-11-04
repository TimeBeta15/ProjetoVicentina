using domain.Interfaces;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Service.BaseContainer
{
    public class BaseService<T> : IBaseService<T> where T : class
    {

        private readonly DataContext context;
        public BaseService(DataContext context)
        {
            this.context = context;
        }

        public void Add(T entity)
        {
            this.context.Add(entity);
        }

        public void Delete(T entity)
        {
            this.context.Set<T>().Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await this.context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(string id)
        {
            return await this.context.Set<T>().FindAsync(id);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await this.context.SaveChangesAsync()) > 0;
        }

        public void Update(T entity)
        {
            this.context.Set<T>().Update(entity);
        }
    }
}
