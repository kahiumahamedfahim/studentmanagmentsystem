using Microsoft.EntityFrameworkCore;
using studentManagmentSystem.DataAccess;
using studentManagmentSystem.Repository.Interfaces;

namespace studentManagmentSystem.Repository
{
    public class GenericRepository<T> : IGenericRepositiry<T> where T : class
    {
        public readonly AppDbContext _context;
        public readonly DbSet<T> _dbSet;
        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
           _dbSet.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
           return  _dbSet.ToList();
        }

        public T? GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
