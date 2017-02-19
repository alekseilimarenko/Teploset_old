using System;
using System.Linq;
using Teploset.EF.Classes;

namespace Teploset.EF
{
    public class RepVacancyCatalog : TeplosetRepository<VacancyCatalog>
    {
        public RepVacancyCatalog(TeplosetUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IQueryable<VacancyCatalog> Select(Guid langTypeId)
        {
            var res = DbSet as IQueryable<VacancyCatalog>;

            return res.Where(i => i.LangTypeId == langTypeId);
        }
    }
}