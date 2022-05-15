using System.Threading.Tasks;
using tcc_pv_api.interfaces;

namespace tcc_pv_api.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    
    {
        public Task<T> Add(T entity)
        {
            //Context.Add(entity);
            return null;
        }

        public Task<T> GetALL()
        {
            //Context.Find();
            return null;
        }

        public Task<T> Delete()
        {
             //Context.Find();
            return null;
        }

        public Task<T> Uptade()
        {
             //Context.Find()
            return null;
        }

        


    }
}