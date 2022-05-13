namespace AMS_Interface_22.Service
{
    public class ServiceBase<T> : IServiceBase where T : class
    {
        public Task<T> Add(T entity){
            return null;
        }

        public Task<T> GetAll(){
            return null;
        }
    }
}