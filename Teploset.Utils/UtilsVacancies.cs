using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teploset.EF;
using Teploset.EF.Classes;
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
            if (langType == "ru")
            {
                return repository
                        .Vacancies
                        .Where(i => i.LangTypeId == Consts.RuLang)
                        .OrderByDefault()
                        .Take(countPost)
                        .ToList();
            }

            return repository
                        .Vacancies
                        .Where(i => i.LangTypeId == Consts.UaLang)
                        .OrderByDefault()
                        .Take(countPost)
                        .ToList();
        }
    }
}
