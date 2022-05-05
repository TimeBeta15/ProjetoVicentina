 public interface serviceBase<T> where T : class
    {
        //C R U D
        void Add(T entity); //C
        Task<IEnumerable<T>> GetAll(); //R
        Task<T> GetById(string id);
        void Update(T entity); //U
        void Delete(T entity); //D
        Task<bool> SaveChangesAsync(); //Salvar (Persistir no Banco de dados)
        
    }