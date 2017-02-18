using System.Collections.Generic;
using Teploset.EF;
using Teploset.EF.Classes;

namespace Teploset.Utils
{
    public static class UtilsVacancies
    {
        public static List<VacancyCatalog> SelectVacanciesListForMainPage(
            TeplosetUnitOfWork repository,
            int countPost,
            string langType)
        {
            //if (langType == "ru")
            //{
            //    return repository
            //            .Vacancies
            //            .Where(i => i.LangTypeId == Consts.RuLang)
            //            .OrderByDefault()
            //            .Take(countPost)
            //            .ToList();
            //}

            //return repository
            //            .Vacancies
            //            .Where(i => i.LangTypeId == Consts.UaLang)
            //            .OrderByDefault()
            //            .Take(countPost)
            //            .ToList();

            return null;
        }
    }
}
