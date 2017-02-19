using System.Linq;

namespace Teploset.EF
{
    public static class ExtNewsCatalog
    {
        public static IQueryable<NewsCatalog> OrderByDefault(this IQueryable<NewsCatalog> q)
        {
            return q.OrderByDescending(i => i.DateTimeCreate);
        }
    }
}
