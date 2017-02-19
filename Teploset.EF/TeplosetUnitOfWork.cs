using System;
using System.Collections;

namespace Teploset.EF
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

        private T GetRepCatalog<T>() where T : class
        {
            var typeName = typeof (T).FullName;
            if (!_h.ContainsKey(typeName))
            {
                var rep = (T) Activator.CreateInstance(typeof (T), this);
                _h[typeName] = rep;
            }
            return (T) _h[typeName];
        }

        public RepPostCatalog PostCatalog
        {
            get { return GetRepCatalog<RepPostCatalog>(); }
        }

        public RepNewsCatalog NewsCatalog
        {
            get { return GetRepCatalog<RepNewsCatalog>(); }
        }

        public RepVacancyCatalog VacancyCatalog
        {
            get { return GetRepCatalog<RepVacancyCatalog>(); }
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        private bool _disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
