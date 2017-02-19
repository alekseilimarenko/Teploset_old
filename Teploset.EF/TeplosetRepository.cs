using System;
using System.Data.Entity;

namespace Teploset.EF
{
    public class TeplosetRepository<T> where T : class
    {
        private readonly Entities _db;

        protected Entities Db
        {
            get { return _db; }
        }

        private readonly DbSet<T> _dbSet;

        public DbSet<T> DbSet
        {
            get { return _dbSet; }
        }

        private TeplosetUnitOfWork _unitOfWork;

        public TeplosetUnitOfWork UnitOfWork 
        {
            get { return _unitOfWork ?? (_unitOfWork = new TeplosetUnitOfWork(Db)); }
        }

        public TeplosetRepository(Entities dbEntities)
        {
            if (dbEntities == null)
            {
                throw new ArgumentNullException("dbEntities");
            }
            _db = dbEntities;
            _dbSet = Db.Set<T>();
        } 

        public TeplosetRepository(TeplosetUnitOfWork unitOfWork) : this(unitOfWork.Db)
        {
            this._unitOfWork = unitOfWork;
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
