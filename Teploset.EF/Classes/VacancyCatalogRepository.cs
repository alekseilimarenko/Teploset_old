namespace Teploset.EF.Classes
{
    public class VacancyCatalogRepository : TeplosetRepository<VacancyCatalog>
    {
        public VacancyCatalogRepository(TeplosetUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}