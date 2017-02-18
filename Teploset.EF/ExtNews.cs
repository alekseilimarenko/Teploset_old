using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teploset.EF
{
    public static class ExtNews
    {
        public static IEnumerable<NewsCatalog> OrderByDefault(this IEnumerable<NewsCatalog> q)
        {
            return q.OrderByDescending(i => i.DateTimeCreate);
        }
    }
}
