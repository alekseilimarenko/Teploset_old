using Teploset.EF.Classes;

namespace Teploset.EF
{
    public class NewsCatalogRepository : TeplosetRepository<NewsCatalog>
    {
        public NewsCatalogRepository(TeplosetUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
