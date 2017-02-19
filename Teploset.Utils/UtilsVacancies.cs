using System.Collections.Generic;
using System.Linq;
using Teploset.EF;
using Teploset.EF.Classes;

namespace Teploset.Utils
{
    public static class UtilsVacancies
    {
        public static List<VacancyCatalog> SelectVacanciesListForMainPage(
            TeplosetUnitOfWork teplosetUnit,
            int countPost,
            string langType)
        {
            if (langType == "ru")
            {
                return teplosetUnit
                        .VacancyCatalog
                        .Select(Consts.RuLang)
                        .OrderByDefault()
                        .Take(countPost)
                        .ToList();
            }

            return teplosetUnit
                        .VacancyCatalog
                        .Select(Consts.UaLang)
                        .OrderByDefault()
                        .Take(countPost)
                        .ToList();
        }
    }
}
