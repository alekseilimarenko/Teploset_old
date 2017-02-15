using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teploset.EF;
using Teploset.EF.Entities;
using Teploset.EF.Interfaces;

namespace Teploset.Utils
{
    public static class UtilsVacancies
    {
        public static List<Vacancy> SelectVacanciesListForMainPage(
            ITeplosetRepository repository,
            int countPost,
            string langType)
        {
            var res = repository.Vacancies.OrderByDefault().Take(countPost).ToList();
            return res;
        }
    }
}
