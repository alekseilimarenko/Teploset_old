using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teploset.EF
{
    public static class ExtPost
    {
        public static IQueryable<PostCatalog> OrderByDefault(this IQueryable<PostCatalog> q)
        {
            return q.OrderByDescending(i => i.DateTimeCreate);
        } 
    }
}
