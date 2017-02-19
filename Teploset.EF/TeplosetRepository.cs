using System;
using System.Data.Entity;

namespace Teploset.EF
{
    public class TeplosetRepository<T> where T : class
    {
        private readonly Entities _dbEntities;

        protected Entities DbEntities
        {
            get { return _dbEntities; }
        }

        private readonly DbSet<T> _dbSet;

        public DbSet<T> DbSet
        {
            get { return _dbSet; }
        }

        private TeplosetUnitOfWork _unitOfWork;
        public TeplosetRepository(TeplosetUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public T FindById(Guid id)
        {
            return DbSet.Find(id);
        }

        public T GetById(Guid id)
        {
            var res = FindById(id);
            if (res == null)
            {
                throw new ApplicationException("Не удалось получить объект " + typeof(T).Name + " по коду " + id + "!");
            }

            return res;
        }

        public void Delete(T item)
        {
            DbSet.Remove(item);
        }

        //IEnumerable<T> GetAll();
        //T Get(Guid id);
        //void Create(T item);
        //void Update(T item);
        //void Delete(T item);
        //void Select(T item, string langType);
    }
}
