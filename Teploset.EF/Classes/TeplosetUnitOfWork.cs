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

        public NewsCatalog

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
