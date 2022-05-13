namespace AMS_Interface_22.Interfaces
{
    public interface IRepositoryBase<T>
    {
        Task<T> Add(T entity);

        Task<T> GetAll();

        Task<T> Delete();

        Task<T> Update();
    }
}