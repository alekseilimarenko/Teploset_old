using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teploset.EF.Classes;

namespace Teploset.EF
{
    public class PostCatalogRepository : TeplosetRepository<PostCatalog>
    {
        public PostCatalogRepository(TeplosetUnitOfWork unitOfWork) : base(unitOfWork)
        {
            
        }

        private IQueryable<PostCatalog> Select(Guid langTypeId)
        {
            var res = DbSet as IQueryable<PostCatalog>;

            return res.Where(i => i.LangTypeId == langTypeId);
        }
    }
}
