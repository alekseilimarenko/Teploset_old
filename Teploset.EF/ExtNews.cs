using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teploset.EF.Entities;

namespace Teploset.EF
{
    public static class ExtNews
    {
        public static IEnumerable<News> OrderByDefault(this IEnumerable<News> q)
        {
            return q.OrderByDescending(i => i.DateTimeCreate);
        }
    }
}
