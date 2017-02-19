using System;
using System.Linq;
using Teploset.EF.Classes;

namespace Teploset.EF
{
    public class RepNewsCatalog : TeplosetRepository<NewsCatalog>
    {
        public RepNewsCatalog(TeplosetUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IQueryable<NewsCatalog> Select(Guid langTypeId)
        {
            var res = DbSet as IQueryable<NewsCatalog>;

            return res.Where(i => i.LangTypeId == langTypeId);
        }
    }
}
