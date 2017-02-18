using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teploset.EF.Entities;

namespace Teploset.EF
{
    public static class ExtPost
    {
        public static IEnumerable<Post> OrderByDefault(this IEnumerable<Post> q)
        {
            return q.OrderByDescending(i => i.DateTimeCreate);
        } 
    }
}
