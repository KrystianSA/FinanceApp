using FinanceApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.DataAccess
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        
        private DbSet<T> _entities;
        private readonly HomeBudgetStorageContext _storageContext;

        public Repository(HomeBudgetStorageContext storageContext)
        {
            _storageContext = storageContext;
            _entities = storageContext.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {   
            return _entities.AsEnumerable();
        }

        public T GetById(int id)
        {
            return _entities.SingleOrDefault(x => x.Id == id);
        }

        public void Insert(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            _entities.Add(entity);
            _storageContext.SaveChanges();
        }

        public void Update(T entity)
        {
            if(entity == null) 
            {
                throw new ArgumentNullException("entity");
            }

            _storageContext.SaveChanges();
        }

        public void Delete(int id)
        {
            T entity = _entities.SingleOrDefault(x=>x.Id== id);
            _entities.Remove(entity);
            _storageContext.SaveChanges();
        }
    }
}
