using System.Linq;

namespace Teploset.EF
{
    public static class ExtPostCatalog
    {
        public static IQueryable<PostCatalog> OrderByDefault(this IQueryable<PostCatalog> q)
        {
            return q.OrderByDescending(i => i.DateTimeCreate);
        } 
    }
}
