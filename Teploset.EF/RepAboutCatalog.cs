using System;
using System.Linq;

namespace Teploset.EF
{
    public class RepAboutCatalog : TeplosetRepository<AboutCatalog>
    {
        public RepAboutCatalog(TeplosetUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public IQueryable<AboutCatalog> Select(Guid langTypeId)
        {
            var res = DbSet as IQueryable<AboutCatalog>;

            return res.Where(i => i.LangTypeId == langTypeId).OrderBy(i=>i.DateTimeCreate);
        }
    }
}

