using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teploset.EF.Entities;

namespace Teploset.EF
{
    public static class ExtVacancy
    {
        public static IEnumerable<Vacancy> OrderByDefault(this IEnumerable<Vacancy> q)
        {
            return q.OrderByDescending(i => i.DateTimeCreate);
        }
    }
}
