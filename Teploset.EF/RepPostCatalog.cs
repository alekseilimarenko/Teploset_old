using System;
using System.Linq;

namespace Teploset.EF
{
    public class RepPostCatalog : TeplosetRepository<PostCatalog>
    {
        public RepPostCatalog(TeplosetUnitOfWork unitOfWork) : base(unitOfWork)
        {
            
        }

        public IQueryable<PostCatalog> Select(Guid langTypeId)
        {
            var res = DbSet as IQueryable<PostCatalog>;

            return res.Where(i => i.LangTypeId == langTypeId);
        }
    }
}
