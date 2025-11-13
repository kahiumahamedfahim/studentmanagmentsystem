namespace studentManagmentSystem.Repository.Interfaces
{
    public interface IGenericRepositiry <T> where T : class
    {
        IEnumerable<T> GetAll();
        T? GetById(object id);
        void Add(T entity);
        void Update(T entity);  
        void Delete(T entity);
        void Save();
    }
}
