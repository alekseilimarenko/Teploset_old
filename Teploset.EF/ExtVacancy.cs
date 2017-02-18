using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teploset.EF
{
    public static class ExtVacancy
    {
        public static IQueryable<VacancyCatalog> OrderByDefault(this IQueryable<VacancyCatalog> q)
        {
            return q.OrderByDescending(i => i.DateTimeCreate);
        }
    }
}
