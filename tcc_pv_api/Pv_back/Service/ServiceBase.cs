using System.Threading.Tasks;
using tcc_pv_api.interfaces;

namespace tcc_pv_api.Service
{
    public class ServiceBase<T> : IServiceBase<T> where T: class
    {
            public Task<T> Add(T entity)
            {

            }

            public Task<T> Delete(T entity)
            {

            }




    } 

}