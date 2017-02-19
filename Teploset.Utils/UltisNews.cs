using System.Collections.Generic;
using System.Linq;
using Teploset.EF;
using Teploset.EF.Classes;

namespace Teploset.Utils
{
    public static class UltisNews
    {
        public static List<NewsCatalog> SelectLastNewsListForMainPage(
            TeplosetUnitOfWork teplosetUnit,
            int countNews, 
            string langType)
        {
            if (langType == "ru")
            {
                return teplosetUnit
                        .NewsCatalog
                        .Select(Consts.RuLang)
                        .OrderByDefault()
                        .Take(countNews)
                        .ToList();
            }
            return teplosetUnit
                        .NewsCatalog
                        .Select(Consts.UaLang)
                        .OrderByDefault()
                        .Take(countNews)
                        .ToList();
        }
    }
}
