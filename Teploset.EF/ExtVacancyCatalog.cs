using System.Linq;

namespace Teploset.EF
{
    public static class ExtVacancyCatalog
    {
        public static IQueryable<VacancyCatalog> OrderByDefault(this IQueryable<VacancyCatalog> q)
        {
            return q.OrderByDescending(i => i.DateTimeCreate);
        }
    }
}
