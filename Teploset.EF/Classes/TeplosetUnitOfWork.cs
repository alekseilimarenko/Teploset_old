using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teploset.EF.Classes
{
    public class TeplosetUnitOfWork : IDisposable
    {
        private readonly Entities _db;

        public TeplosetUnitOfWork(Entities db)
        {
            _db = db;
        }

        public Entities Db
        {
            get { return _db; }
        }

        private readonly Hashtable _h = new Hashtable();

        public T GetRepCatalog<T>() where T : class
        {
            var typeName = typeof (T).FullName;
            if (!_h.ContainsKey(typeName))
            {
                var rep = (T) Activator.CreateInstance(typeof (T), this);
                _h[typeName] = rep;
            }
            return (T) _h[typeName];
        }

        public PostCatalogRepository PostCatalog
        {
            get { return GetRepCatalog<PostCatalogRepository>(); }
        }

        public NewsCatalogRepository NewsCatalog
        {
            get { return GetRepCatalog<NewsCatalogRepository>(); }
        }

        public VacancyCatalogRepository VacancyCatalog
        {
            get { return GetRepCatalog<VacancyCatalogRepository>(); }
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
