namespace AMS_Interface_22.Interfaces
{
    public interface IServiceBase<T> where T : class
    {
        Task<T> Add(T entity);

        Task<T> GetAll();
    }
}